using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        HtmlElement login, senha, entrar;
        Form2 form2 = new Form2();
        HtmlDocument document;

        public Form1()
        {
            InitializeComponent();
            document = form2.WebNavigate("https://www.prf.gov.br/sipac/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SendData();
            form2.Show();
            this.Hide();
        }

        private void SendData()
        {
            GetInputs();

            login.SetAttribute("value", maskedTextBox1.Text);
            senha.SetAttribute("value", maskedTextBox2.Text);

            entrar.InvokeMember("Click");   
        }

        private void GetInputs()
        {
            HtmlElementCollection inputs = document.GetElementsByTagName("input");
            HtmlElementCollection divs = document.GetElementsByTagName("div");

            foreach (HtmlElement element in divs)
            {
                if (element.InnerHtml != null)
                {
                    if (element.InnerHtml.Contains("Entrar"))
                        entrar = element;
                }
            }

            foreach (HtmlElement element in inputs)
            {
                if (element.Name == "login")
                {
                    login = element;
                }
                else if (element.Name == "senha")
                {
                    senha = element;
                }
                else if (element.OuterHtml.Contains("Entrar"))
                {
                    entrar = element;
                }
            }
        }
    }
}
