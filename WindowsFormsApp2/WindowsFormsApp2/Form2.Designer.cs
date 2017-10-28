namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.InsereNotaAlmox = new System.Windows.Forms.Button();
            this.ImprimirComprovantesAlmox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(50, 50);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(702, 104);
            this.webBrowser1.TabIndex = 0;
            // 
            // InsereNotaAlmox
            // 
            this.InsereNotaAlmox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsereNotaAlmox.Location = new System.Drawing.Point(108, 166);
            this.InsereNotaAlmox.MinimumSize = new System.Drawing.Size(120, 30);
            this.InsereNotaAlmox.Name = "InsereNotaAlmox";
            this.InsereNotaAlmox.Size = new System.Drawing.Size(120, 30);
            this.InsereNotaAlmox.TabIndex = 1;
            this.InsereNotaAlmox.Text = "Inserir Nota Fiscal";
            this.InsereNotaAlmox.UseVisualStyleBackColor = true;
            this.InsereNotaAlmox.Click += new System.EventHandler(this.InsereNotaAlmox_Click);
            // 
            // ImprimirComprovantesAlmox
            // 
            this.ImprimirComprovantesAlmox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImprimirComprovantesAlmox.Location = new System.Drawing.Point(108, 227);
            this.ImprimirComprovantesAlmox.MinimumSize = new System.Drawing.Size(120, 30);
            this.ImprimirComprovantesAlmox.Name = "ImprimirComprovantesAlmox";
            this.ImprimirComprovantesAlmox.Size = new System.Drawing.Size(120, 56);
            this.ImprimirComprovantesAlmox.TabIndex = 2;
            this.ImprimirComprovantesAlmox.Text = "Imprimir todos os comprovantes de Requisição";
            this.ImprimirComprovantesAlmox.UseVisualStyleBackColor = true;
            this.ImprimirComprovantesAlmox.Click += new System.EventHandler(this.ImprimirComprovantesAlmox_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 601);
            this.Controls.Add(this.ImprimirComprovantesAlmox);
            this.Controls.Add(this.InsereNotaAlmox);
            this.Controls.Add(this.webBrowser1);
            this.MinimumSize = new System.Drawing.Size(720, 640);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button InsereNotaAlmox;
        private System.Windows.Forms.Button ImprimirComprovantesAlmox;
    }
}