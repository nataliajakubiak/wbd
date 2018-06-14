namespace WindowsFormsApp1
{
    partial class mojeDane
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesel_textBox = new System.Windows.Forms.TextBox();
            this.dataUr_textBox = new System.Windows.Forms.TextBox();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drugieImie_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imie_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ulica_textBox = new System.Windows.Forms.TextBox();
            this.nrLok_textBox = new System.Windows.Forms.TextBox();
            this.nrBud_textBox = new System.Windows.Forms.TextBox();
            this.kodPocztowy_textBox = new System.Windows.Forms.TextBox();
            this.miasto_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nrTel_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plec_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nrKonta_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.modyfikujButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.odswiezButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pesel_textBox);
            this.groupBox1.Controls.Add(this.dataUr_textBox);
            this.groupBox1.Controls.Add(this.nazwisko_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.drugieImie_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.imie_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane podstawowe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data urodzenia:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PESEL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwisko:";
            // 
            // pesel_textBox
            // 
            this.pesel_textBox.Location = new System.Drawing.Point(87, 71);
            this.pesel_textBox.Name = "pesel_textBox";
            this.pesel_textBox.ReadOnly = true;
            this.pesel_textBox.Size = new System.Drawing.Size(100, 20);
            this.pesel_textBox.TabIndex = 6;
            // 
            // dataUr_textBox
            // 
            this.dataUr_textBox.Location = new System.Drawing.Point(349, 49);
            this.dataUr_textBox.Name = "dataUr_textBox";
            this.dataUr_textBox.ReadOnly = true;
            this.dataUr_textBox.Size = new System.Drawing.Size(100, 20);
            this.dataUr_textBox.TabIndex = 5;
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(87, 46);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.ReadOnly = true;
            this.nazwisko_textBox.Size = new System.Drawing.Size(100, 20);
            this.nazwisko_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drugie imię:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // drugieImie_textBox
            // 
            this.drugieImie_textBox.Location = new System.Drawing.Point(349, 22);
            this.drugieImie_textBox.Name = "drugieImie_textBox";
            this.drugieImie_textBox.ReadOnly = true;
            this.drugieImie_textBox.Size = new System.Drawing.Size(100, 20);
            this.drugieImie_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię:";
            // 
            // imie_textBox
            // 
            this.imie_textBox.Location = new System.Drawing.Point(87, 19);
            this.imie_textBox.Name = "imie_textBox";
            this.imie_textBox.ReadOnly = true;
            this.imie_textBox.Size = new System.Drawing.Size(100, 20);
            this.imie_textBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ulica_textBox);
            this.groupBox2.Controls.Add(this.nrLok_textBox);
            this.groupBox2.Controls.Add(this.nrBud_textBox);
            this.groupBox2.Controls.Add(this.kodPocztowy_textBox);
            this.groupBox2.Controls.Add(this.miasto_textBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane adresowe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nr lokalu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Miasto:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nr budynku:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kod pocztowy:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ulica:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ulica_textBox
            // 
            this.ulica_textBox.Location = new System.Drawing.Point(349, 19);
            this.ulica_textBox.Name = "ulica_textBox";
            this.ulica_textBox.ReadOnly = true;
            this.ulica_textBox.Size = new System.Drawing.Size(100, 20);
            this.ulica_textBox.TabIndex = 5;
            // 
            // nrLok_textBox
            // 
            this.nrLok_textBox.Location = new System.Drawing.Point(349, 45);
            this.nrLok_textBox.Name = "nrLok_textBox";
            this.nrLok_textBox.ReadOnly = true;
            this.nrLok_textBox.Size = new System.Drawing.Size(100, 20);
            this.nrLok_textBox.TabIndex = 4;
            // 
            // nrBud_textBox
            // 
            this.nrBud_textBox.Location = new System.Drawing.Point(87, 49);
            this.nrBud_textBox.Name = "nrBud_textBox";
            this.nrBud_textBox.ReadOnly = true;
            this.nrBud_textBox.Size = new System.Drawing.Size(100, 20);
            this.nrBud_textBox.TabIndex = 3;
            // 
            // kodPocztowy_textBox
            // 
            this.kodPocztowy_textBox.Location = new System.Drawing.Point(87, 77);
            this.kodPocztowy_textBox.Name = "kodPocztowy_textBox";
            this.kodPocztowy_textBox.ReadOnly = true;
            this.kodPocztowy_textBox.Size = new System.Drawing.Size(100, 20);
            this.kodPocztowy_textBox.TabIndex = 2;
            // 
            // miasto_textBox
            // 
            this.miasto_textBox.Location = new System.Drawing.Point(87, 19);
            this.miasto_textBox.Name = "miasto_textBox";
            this.miasto_textBox.ReadOnly = true;
            this.miasto_textBox.Size = new System.Drawing.Size(100, 20);
            this.miasto_textBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.nrTel_textBox);
            this.groupBox3.Controls.Add(this.email_textBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 58);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane kontaktowe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nr telefonu:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // nrTel_textBox
            // 
            this.nrTel_textBox.Location = new System.Drawing.Point(87, 19);
            this.nrTel_textBox.Name = "nrTel_textBox";
            this.nrTel_textBox.ReadOnly = true;
            this.nrTel_textBox.Size = new System.Drawing.Size(100, 20);
            this.nrTel_textBox.TabIndex = 3;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(302, 21);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.ReadOnly = true;
            this.email_textBox.Size = new System.Drawing.Size(147, 20);
            this.email_textBox.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plec_textBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.nrKonta_textBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 72);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inne";
            // 
            // plec_textBox
            // 
            this.plec_textBox.Location = new System.Drawing.Point(385, 49);
            this.plec_textBox.Name = "plec_textBox";
            this.plec_textBox.ReadOnly = true;
            this.plec_textBox.Size = new System.Drawing.Size(36, 20);
            this.plec_textBox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Płeć:";
            // 
            // nrKonta_textBox
            // 
            this.nrKonta_textBox.Location = new System.Drawing.Point(122, 23);
            this.nrKonta_textBox.Name = "nrKonta_textBox";
            this.nrKonta_textBox.ReadOnly = true;
            this.nrKonta_textBox.Size = new System.Drawing.Size(299, 20);
            this.nrKonta_textBox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nr konta bankowego:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // modyfikujButton
            // 
            this.modyfikujButton.Location = new System.Drawing.Point(144, 364);
            this.modyfikujButton.Name = "modyfikujButton";
            this.modyfikujButton.Size = new System.Drawing.Size(89, 23);
            this.modyfikujButton.TabIndex = 13;
            this.modyfikujButton.Text = "Modyfikuj dane";
            this.modyfikujButton.UseVisualStyleBackColor = true;
            this.modyfikujButton.Click += new System.EventHandler(this.modyfikujClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.powrotClick);
            // 
            // zapiszButton
            // 
            this.zapiszButton.Enabled = false;
            this.zapiszButton.Location = new System.Drawing.Point(264, 364);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(89, 23);
            this.zapiszButton.TabIndex = 15;
            this.zapiszButton.Text = "Zmień";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszClick);
            // 
            // odswiezButton
            // 
            this.odswiezButton.Enabled = false;
            this.odswiezButton.Location = new System.Drawing.Point(372, 364);
            this.odswiezButton.Name = "odswiezButton";
            this.odswiezButton.Size = new System.Drawing.Size(89, 23);
            this.odswiezButton.TabIndex = 16;
            this.odswiezButton.Text = "Odśwież";
            this.odswiezButton.UseVisualStyleBackColor = true;
            this.odswiezButton.Click += new System.EventHandler(this.odswiezClick);
            // 
            // mojeDane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 397);
            this.Controls.Add(this.odswiezButton);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modyfikujButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mojeDane";
            this.Text = "Dane pracownika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pesel_textBox;
        private System.Windows.Forms.TextBox dataUr_textBox;
        private System.Windows.Forms.TextBox nazwisko_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drugieImie_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imie_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ulica_textBox;
        private System.Windows.Forms.TextBox nrLok_textBox;
        private System.Windows.Forms.TextBox nrBud_textBox;
        private System.Windows.Forms.TextBox kodPocztowy_textBox;
        private System.Windows.Forms.TextBox miasto_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nrTel_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox nrKonta_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox plec_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button modyfikujButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Button odswiezButton;
    }
}