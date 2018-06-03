namespace WindowsFormsApp1
{
    partial class Panel_logowania
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
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_haslo = new System.Windows.Forms.TextBox();
            this.label_panel_logowania = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_haslo = new System.Windows.Forms.Label();
            this.button_zaloguj = new System.Windows.Forms.Button();
            this.button_wyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_login
            // 
            this.text_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_login.Location = new System.Drawing.Point(173, 108);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(187, 26);
            this.text_login.TabIndex = 0;
            this.text_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_haslo
            // 
            this.text_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_haslo.Location = new System.Drawing.Point(173, 155);
            this.text_haslo.Name = "text_haslo";
            this.text_haslo.Size = new System.Drawing.Size(187, 26);
            this.text_haslo.TabIndex = 1;
            // 
            // label_panel_logowania
            // 
            this.label_panel_logowania.AutoSize = true;
            this.label_panel_logowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_panel_logowania.Location = new System.Drawing.Point(105, 25);
            this.label_panel_logowania.Name = "label_panel_logowania";
            this.label_panel_logowania.Size = new System.Drawing.Size(280, 24);
            this.label_panel_logowania.TabIndex = 2;
            this.label_panel_logowania.Text = "Aby kontynować, zaloguj się!";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login.Location = new System.Drawing.Point(106, 108);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(52, 20);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Login:";
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_haslo.Location = new System.Drawing.Point(106, 159);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(55, 20);
            this.label_haslo.TabIndex = 4;
            this.label_haslo.Text = "Hasło:";
            // 
            // button_zaloguj
            // 
            this.button_zaloguj.Location = new System.Drawing.Point(109, 243);
            this.button_zaloguj.Name = "button_zaloguj";
            this.button_zaloguj.Size = new System.Drawing.Size(112, 46);
            this.button_zaloguj.TabIndex = 5;
            this.button_zaloguj.Text = "Zaloguj się";
            this.button_zaloguj.UseVisualStyleBackColor = true;
            this.button_zaloguj.Click += new System.EventHandler(this.button_zaloguj_Click);
            // 
            // button_wyjscie
            // 
            this.button_wyjscie.Location = new System.Drawing.Point(246, 243);
            this.button_wyjscie.Name = "button_wyjscie";
            this.button_wyjscie.Size = new System.Drawing.Size(114, 46);
            this.button_wyjscie.TabIndex = 6;
            this.button_wyjscie.Text = "Wyjście";
            this.button_wyjscie.UseVisualStyleBackColor = true;
            this.button_wyjscie.Click += new System.EventHandler(this.button_wyjscie_Click);
            // 
            // Panel_logowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.button_wyjscie);
            this.Controls.Add(this.button_zaloguj);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_panel_logowania);
            this.Controls.Add(this.text_haslo);
            this.Controls.Add(this.text_login);
            this.Name = "Panel_logowania";
            this.Text = "Schronisko DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_haslo;
        private System.Windows.Forms.Label label_panel_logowania;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_haslo;
        private System.Windows.Forms.Button button_zaloguj;
        private System.Windows.Forms.Button button_wyjscie;
        public System.Windows.Forms.TextBox text_login;
    }
}

