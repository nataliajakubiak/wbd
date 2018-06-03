namespace WindowsFormsApp1
{
    partial class Panel_usuwania
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_goback = new System.Windows.Forms.Button();
            this.comboBox_select = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.comboBox_show = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_review = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_goback);
            this.panel1.Controls.Add(this.comboBox_select);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Location = new System.Drawing.Point(74, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 88);
            this.panel1.TabIndex = 1;
            // 
            // button_goback
            // 
            this.button_goback.Location = new System.Drawing.Point(15, 65);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(174, 23);
            this.button_goback.TabIndex = 10;
            this.button_goback.Text = "Powrót do menu";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_select
            // 
            this.comboBox_select.FormattingEnabled = true;
            this.comboBox_select.Location = new System.Drawing.Point(203, 35);
            this.comboBox_select.Name = "comboBox_select";
            this.comboBox_select.Size = new System.Drawing.Size(121, 21);
            this.comboBox_select.TabIndex = 9;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(262, 62);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(161, 23);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.Text = "Odśwież";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(354, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj  atrybut rekordu, który ma ostać usunięty:";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(470, 62);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(176, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "Zatwierdź zmianę";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // comboBox_show
            // 
            this.comboBox_show.FormattingEnabled = true;
            this.comboBox_show.Location = new System.Drawing.Point(416, 72);
            this.comboBox_show.Name = "comboBox_show";
            this.comboBox_show.Size = new System.Drawing.Size(254, 21);
            this.comboBox_show.TabIndex = 2;
            this.comboBox_show.SelectedIndexChanged += new System.EventHandler(this.comboBox_show_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz tabelę, z której zostanie usunięty rekord:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(664, 234);
            this.dataGridView1.TabIndex = 5;
            // 
            // label_review
            // 
            this.label_review.AutoSize = true;
            this.label_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_review.Location = new System.Drawing.Point(258, 27);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(270, 31);
            this.label_review.TabIndex = 6;
            this.label_review.Text = "Usuwanie rekordów";
            this.label_review.Click += new System.EventHandler(this.label_review_Click);
            // 
            // Panel_usuwania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_review);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_show);
            this.Controls.Add(this.panel1);
            this.Name = "Panel_usuwania";
            this.Text = "Usuwanie rekordów";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_show;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_review;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_select;
        private System.Windows.Forms.Button button_goback;
    }
}