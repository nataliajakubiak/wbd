namespace WindowsFormsApp1
{
    partial class Panel_modyfikacji
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
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_show = new System.Windows.Forms.ComboBox();
            this.dataGridView_review = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_review = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_goback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_review)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(265, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(122, 40);
            this.button_refresh.TabIndex = 0;
            this.button_refresh.Text = "Odśwież";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_show
            // 
            this.comboBox_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_show.FormattingEnabled = true;
            this.comboBox_show.Location = new System.Drawing.Point(282, 72);
            this.comboBox_show.Name = "comboBox_show";
            this.comboBox_show.Size = new System.Drawing.Size(275, 24);
            this.comboBox_show.TabIndex = 1;
            this.comboBox_show.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView_review
            // 
            this.dataGridView_review.AllowUserToAddRows = false;
            this.dataGridView_review.AllowUserToDeleteRows = false;
            this.dataGridView_review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_review.Location = new System.Drawing.Point(77, 108);
            this.dataGridView_review.Name = "dataGridView_review";
            this.dataGridView_review.Size = new System.Drawing.Size(666, 265);
            this.dataGridView_review.TabIndex = 2;
            this.dataGridView_review.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_review_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(146, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz tabelę:";
            // 
            // label_review
            // 
            this.label_review.AutoSize = true;
            this.label_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_review.Location = new System.Drawing.Point(286, 25);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(271, 31);
            this.label_review.TabIndex = 4;
            this.label_review.Text = "Modyfikacja danych";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(521, 3);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(122, 40);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "Zatwierdź zmiany";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_goback
            // 
            this.button_goback.Location = new System.Drawing.Point(22, 3);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(120, 40);
            this.button_goback.TabIndex = 6;
            this.button_goback.Text = "Powrót do menu";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.button_goback_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Controls.Add(this.button_goback);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Location = new System.Drawing.Point(77, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 59);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Panel_modyfikacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_review);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_review);
            this.Controls.Add(this.comboBox_show);
            this.Name = "Panel_modyfikacji";
            this.Text = "Modyfkuj rekordy";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_review)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_show;
        private System.Windows.Forms.DataGridView dataGridView_review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_review;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_goback;
        private System.Windows.Forms.Panel panel1;
    }
}