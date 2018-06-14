namespace WindowsFormsApp1
{
    partial class Panel_hasla
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
            this.button_goback = new System.Windows.Forms.Button();
            this.label_review = new System.Windows.Forms.Label();
            this.label_bbotak = new System.Windows.Forms.Label();
            this.textBox_haslo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_haslo2 = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_goback
            // 
            this.button_goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_goback.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_goback.Location = new System.Drawing.Point(138, 262);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(147, 56);
            this.button_goback.TabIndex = 0;
            this.button_goback.Text = "Powrót do menu";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.button_goback_Click);
            // 
            // label_review
            // 
            this.label_review.AutoSize = true;
            this.label_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_review.Location = new System.Drawing.Point(177, 30);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(188, 31);
            this.label_review.TabIndex = 8;
            this.label_review.Text = "Zmiana hasła";
            // 
            // label_bbotak
            // 
            this.label_bbotak.AutoSize = true;
            this.label_bbotak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bbotak.Location = new System.Drawing.Point(134, 107);
            this.label_bbotak.Name = "label_bbotak";
            this.label_bbotak.Size = new System.Drawing.Size(96, 20);
            this.label_bbotak.TabIndex = 9;
            this.label_bbotak.Text = "Nowe hasło:";
            // 
            // textBox_haslo1
            // 
            this.textBox_haslo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_haslo1.Location = new System.Drawing.Point(284, 107);
            this.textBox_haslo1.Name = "textBox_haslo1";
            this.textBox_haslo1.Size = new System.Drawing.Size(166, 26);
            this.textBox_haslo1.TabIndex = 10;
            this.textBox_haslo1.TextChanged += new System.EventHandler(this.textBox_haslo1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(134, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Potwierdź hasło:";
            // 
            // textBox_haslo2
            // 
            this.textBox_haslo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_haslo2.Location = new System.Drawing.Point(284, 174);
            this.textBox_haslo2.Name = "textBox_haslo2";
            this.textBox_haslo2.Size = new System.Drawing.Size(166, 26);
            this.textBox_haslo2.TabIndex = 12;
            this.textBox_haslo2.TextChanged += new System.EventHandler(this.textBox_haslo2_TextChanged);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(303, 262);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(147, 56);
            this.button_ok.TabIndex = 13;
            this.button_ok.Text = "Zmień hasło";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Panel_hasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_haslo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_haslo1);
            this.Controls.Add(this.label_bbotak);
            this.Controls.Add(this.label_review);
            this.Controls.Add(this.button_goback);
            this.Name = "Panel_hasla";
            this.Text = "Panel_hasla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_goback;
        private System.Windows.Forms.Label label_review;
        private System.Windows.Forms.Label label_bbotak;
        private System.Windows.Forms.TextBox textBox_haslo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_haslo2;
        private System.Windows.Forms.Button button_ok;
    }
}