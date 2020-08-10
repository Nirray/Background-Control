namespace NirrayKillerApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Licznik_SprawdzanieStrony = new System.Windows.Forms.Timer(this.components);
            this.UruchomInternetPonownie = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmd_line = new System.Windows.Forms.TextBox();
            this.Webbo = new System.Windows.Forms.WebBrowser();
            this.HBO_FORCE_ERROR = new System.Windows.Forms.Timer(this.components);
            this.CDA_FORCE_ERROR = new System.Windows.Forms.Timer(this.components);
            this.YOUTUBE_FORCE_ERROR = new System.Windows.Forms.Timer(this.components);
            this.ConstContainer = new System.Windows.Forms.TextBox();
            this.NETFLIX_FORCE_ERROR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Licznik_SprawdzanieStrony
            // 
            this.Licznik_SprawdzanieStrony.Enabled = true;
            this.Licznik_SprawdzanieStrony.Interval = 5000;
            this.Licznik_SprawdzanieStrony.Tick += new System.EventHandler(this.Licznik_SprawdzanieStrony_Tick);
            // 
            // UruchomInternetPonownie
            // 
            this.UruchomInternetPonownie.Tick += new System.EventHandler(this.UruchomInternetPonownie_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(100, 95);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cmd_line
            // 
            this.cmd_line.Location = new System.Drawing.Point(12, 133);
            this.cmd_line.Name = "cmd_line";
            this.cmd_line.ReadOnly = true;
            this.cmd_line.Size = new System.Drawing.Size(100, 20);
            this.cmd_line.TabIndex = 1;
            // 
            // Webbo
            // 
            this.Webbo.Location = new System.Drawing.Point(12, 159);
            this.Webbo.MinimumSize = new System.Drawing.Size(20, 20);
            this.Webbo.Name = "Webbo";
            this.Webbo.Size = new System.Drawing.Size(74, 41);
            this.Webbo.TabIndex = 2;
            this.Webbo.Url = new System.Uri("http://nirray.bplaced.net/Download/egg/refresh.php", System.UriKind.Absolute);
            // 
            // HBO_FORCE_ERROR
            // 
            this.HBO_FORCE_ERROR.Interval = 2000;
            this.HBO_FORCE_ERROR.Tick += new System.EventHandler(this.HBO_FORCE_ERROR_Tick);
            // 
            // CDA_FORCE_ERROR
            // 
            this.CDA_FORCE_ERROR.Interval = 2000;
            this.CDA_FORCE_ERROR.Tick += new System.EventHandler(this.CDA_FORCE_ERROR_Tick);
            // 
            // YOUTUBE_FORCE_ERROR
            // 
            this.YOUTUBE_FORCE_ERROR.Interval = 2000;
            this.YOUTUBE_FORCE_ERROR.Tick += new System.EventHandler(this.YOUTUBE_FORCE_ERROR_Tick);
            // 
            // ConstContainer
            // 
            this.ConstContainer.Location = new System.Drawing.Point(12, 218);
            this.ConstContainer.Name = "ConstContainer";
            this.ConstContainer.ReadOnly = true;
            this.ConstContainer.Size = new System.Drawing.Size(100, 20);
            this.ConstContainer.TabIndex = 3;
            // 
            // NETFLIX_FORCE_ERROR
            // 
            this.NETFLIX_FORCE_ERROR.Interval = 2000;
            this.NETFLIX_FORCE_ERROR.Tick += new System.EventHandler(this.NETFLIX_FORCE_ERROR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 251);
            this.Controls.Add(this.ConstContainer);
            this.Controls.Add(this.Webbo);
            this.Controls.Add(this.cmd_line);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(9999, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.PierwszeUruchomienie);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer Licznik_SprawdzanieStrony;
        public System.Windows.Forms.Timer UruchomInternetPonownie;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox cmd_line;
        private System.Windows.Forms.WebBrowser Webbo;
        private System.Windows.Forms.Timer HBO_FORCE_ERROR;
        private System.Windows.Forms.Timer CDA_FORCE_ERROR;
        private System.Windows.Forms.Timer YOUTUBE_FORCE_ERROR;
        private System.Windows.Forms.TextBox ConstContainer;
        private System.Windows.Forms.Timer NETFLIX_FORCE_ERROR;
    }
}

