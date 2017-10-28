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
    public partial class Form2 : Form
    {
        HtmlDocument doc;
        HtmlElement patrimonio, almoxarifado;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public HtmlDocument WebNavigate(string url)
        {

            this.webBrowser1.Navigate(url);
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            return webBrowser1.Document;

        }

        private void ImprimirComprovantesAlmox_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://www.prf.gov.br/sipac/atendimentoRapido.do?aba=requisicoes-menualmoxarifado");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            doc = webBrowser1.Document;
            HtmlElementCollection a = doc.GetElementsByTagName("a");
            List<string> links = new List<string>();

            foreach(HtmlElement element in a)
            {
                if (element.OuterHtml.Contains("comprovante"))
                {
                    links.Add(element.GetAttribute("href"));
                }
            }
            foreach(string link in links)
            {
                webBrowser1.Navigate(link);
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
                webBrowser1.Print();
                webBrowser1.GoBack();
            }
        }

        private void InsereNotaAlmox_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.prf.gov.br/sipac/populaCadNotaFiscal.do?dispatch=popular&amp;inicioCadastro=true&amp;aba=estoque-menualmoxarifado");
        }


    }
}
