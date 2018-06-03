namespace WindowsFormsApp1
{
    partial class Panel_dodawania
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
            this.dataGridView_review = new System.Windows.Forms.DataGridView();
            this.label_review = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_show = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_review)).BeginInit();
            this.SuspendLayout();
            // 
            // button_goback
            // 
            this.button_goback.Location = new System.Drawing.Point(150, 394);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(157, 44);
            this.button_goback.TabIndex = 0;
            this.button_goback.Text = "Powrót do menu";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_review
            // 
            this.dataGridView_review.AllowUserToDeleteRows = false;
            this.dataGridView_review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_review.Location = new System.Drawing.Point(59, 93);
            this.dataGridView_review.Name = "dataGridView_review";
            this.dataGridView_review.Size = new System.Drawing.Size(628, 286);
            this.dataGridView_review.TabIndex = 1;
            // 
            // label_review
            // 
            this.label_review.AutoSize = true;
            this.label_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_review.Location = new System.Drawing.Point(225, 23);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(287, 31);
            this.label_review.TabIndex = 7;
            this.label_review.Text = "Dodawanie rekordów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz tabelę, do której chcesz dodać rekord:";
            // 
            // comboBox_show
            // 
            this.comboBox_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_show.FormattingEnabled = true;
            this.comboBox_show.Location = new System.Drawing.Point(433, 63);
            this.comboBox_show.Name = "comboBox_show";
            this.comboBox_show.Size = new System.Drawing.Size(254, 24);
            this.comboBox_show.TabIndex = 9;
            this.comboBox_show.SelectedIndexChanged += new System.EventHandler(this.comboBox_show_SelectedIndexChanged);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(443, 394);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(156, 44);
            this.button_ok.TabIndex = 10;
            this.button_ok.Text = "Dodaj";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Panel_dodawania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.comboBox_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_review);
            this.Controls.Add(this.dataGridView_review);
            this.Controls.Add(this.button_goback);
            this.Name = "Panel_dodawania";
            this.Text = "Dodawanie rekordów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_review)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_goback;
        private System.Windows.Forms.DataGridView dataGridView_review;
        private System.Windows.Forms.Label label_review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_show;
        private System.Windows.Forms.Button button_ok;
    }
}