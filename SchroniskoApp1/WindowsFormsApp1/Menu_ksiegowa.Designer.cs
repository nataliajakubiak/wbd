namespace WindowsFormsApp1
{
    partial class Menu_ksiegowa
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
            this.button_review = new System.Windows.Forms.Button();
            this.button_new_record = new System.Windows.Forms.Button();
            this.button_modify_record = new System.Windows.Forms.Button();
            this.button_delete_record = new System.Windows.Forms.Button();
            this.button_change_password = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_review
            // 
            this.button_review.Location = new System.Drawing.Point(121, 12);
            this.button_review.Name = "button_review";
            this.button_review.Size = new System.Drawing.Size(235, 40);
            this.button_review.TabIndex = 1;
            this.button_review.Text = "Przeglądaj";
            this.button_review.UseVisualStyleBackColor = true;
            this.button_review.Click += new System.EventHandler(this.przegladaj_click);
            // 
            // button_new_record
            // 
            this.button_new_record.Location = new System.Drawing.Point(121, 58);
            this.button_new_record.Name = "button_new_record";
            this.button_new_record.Size = new System.Drawing.Size(235, 40);
            this.button_new_record.TabIndex = 2;
            this.button_new_record.Text = "Dodaj nowy rekord";
            this.button_new_record.UseVisualStyleBackColor = true;
            this.button_new_record.Click += new System.EventHandler(this.nowyRekord_Click);
            // 
            // button_modify_record
            // 
            this.button_modify_record.Location = new System.Drawing.Point(121, 104);
            this.button_modify_record.Name = "button_modify_record";
            this.button_modify_record.Size = new System.Drawing.Size(235, 40);
            this.button_modify_record.TabIndex = 3;
            this.button_modify_record.Text = "Modyfikuj rekordy";
            this.button_modify_record.UseVisualStyleBackColor = true;
            // 
            // button_delete_record
            // 
            this.button_delete_record.Location = new System.Drawing.Point(121, 150);
            this.button_delete_record.Name = "button_delete_record";
            this.button_delete_record.Size = new System.Drawing.Size(235, 40);
            this.button_delete_record.TabIndex = 4;
            this.button_delete_record.Text = "Usuń rekordy";
            this.button_delete_record.UseVisualStyleBackColor = true;
            // 
            // button_change_password
            // 
            this.button_change_password.Location = new System.Drawing.Point(121, 196);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(235, 40);
            this.button_change_password.TabIndex = 5;
            this.button_change_password.Text = "Zmień hasło";
            this.button_change_password.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(121, 242);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(235, 40);
            this.button_logout.TabIndex = 6;
            this.button_logout.Text = "Wyloguj się";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(121, 288);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(235, 40);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Zakończ pracę z programem";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // Menu_ksiegowa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_change_password);
            this.Controls.Add(this.button_delete_record);
            this.Controls.Add(this.button_modify_record);
            this.Controls.Add(this.button_new_record);
            this.Controls.Add(this.button_review);
            this.Name = "Menu_ksiegowa";
            this.Text = "Menu_ksiegowa";
            this.Load += new System.EventHandler(this.Menu_ksiegowa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_review;
        private System.Windows.Forms.Button button_new_record;
        private System.Windows.Forms.Button button_modify_record;
        private System.Windows.Forms.Button button_delete_record;
        private System.Windows.Forms.Button button_change_password;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_exit;
    }
}