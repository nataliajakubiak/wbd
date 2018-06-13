namespace WindowsFormsApp1
{
    partial class Panel_przegladania
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
            this.label_review = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_show = new System.Windows.Forms.ComboBox();
            this.dataGridView_review = new System.Windows.Forms.DataGridView();
            this.button_goback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_order = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_sort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sort = new System.Windows.Forms.Button();
            this.TypUzytkownika_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_review)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_review
            // 
            this.label_review.AutoSize = true;
            this.label_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_review.Location = new System.Drawing.Point(292, 18);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(231, 31);
            this.label_review.TabIndex = 0;
            this.label_review.Text = "Przegląd danych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(104, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz tabelę do wyświetlenia:";
            // 
            // comboBox_show
            // 
            this.comboBox_show.FormattingEnabled = true;
            this.comboBox_show.Location = new System.Drawing.Point(302, 66);
            this.comboBox_show.Name = "comboBox_show";
            this.comboBox_show.Size = new System.Drawing.Size(215, 21);
            this.comboBox_show.TabIndex = 2;
            this.comboBox_show.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView_review
            // 
            this.dataGridView_review.AllowUserToAddRows = false;
            this.dataGridView_review.AllowUserToDeleteRows = false;
            this.dataGridView_review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_review.Location = new System.Drawing.Point(101, 94);
            this.dataGridView_review.Name = "dataGridView_review";
            this.dataGridView_review.ReadOnly = true;
            this.dataGridView_review.Size = new System.Drawing.Size(623, 240);
            this.dataGridView_review.TabIndex = 3;
            // 
            // button_goback
            // 
            this.button_goback.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.button_goback.Location = new System.Drawing.Point(302, 415);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(221, 23);
            this.button_goback.TabIndex = 4;
            this.button_goback.Text = "Powrót do menu";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.button_goback_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_order);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_sort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_sort);
            this.panel1.Location = new System.Drawing.Point(101, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 69);
            this.panel1.TabIndex = 5;
            // 
            // comboBox_order
            // 
            this.comboBox_order.FormattingEnabled = true;
            this.comboBox_order.Location = new System.Drawing.Point(201, 37);
            this.comboBox_order.Name = "comboBox_order";
            this.comboBox_order.Size = new System.Drawing.Size(221, 21);
            this.comboBox_order.TabIndex = 4;
            this.comboBox_order.SelectedIndexChanged += new System.EventHandler(this.comboBox_order_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wybierz kolejność sortowania:";
            // 
            // comboBox_sort
            // 
            this.comboBox_sort.FormattingEnabled = true;
            this.comboBox_sort.Location = new System.Drawing.Point(201, 10);
            this.comboBox_sort.Name = "comboBox_sort";
            this.comboBox_sort.Size = new System.Drawing.Size(221, 21);
            this.comboBox_sort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz atrybut sortowania:";
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(485, 32);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(124, 23);
            this.button_sort.TabIndex = 0;
            this.button_sort.Text = "Sortuj";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // TypUzytkownika_label
            // 
            this.TypUzytkownika_label.AutoSize = true;
            this.TypUzytkownika_label.Location = new System.Drawing.Point(55, 18);
            this.TypUzytkownika_label.Name = "TypUzytkownika_label";
            this.TypUzytkownika_label.Size = new System.Drawing.Size(0, 13);
            this.TypUzytkownika_label.TabIndex = 6;
            // 
            // Panel_przegladania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypUzytkownika_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_goback);
            this.Controls.Add(this.dataGridView_review);
            this.Controls.Add(this.comboBox_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_review);
            this.Name = "Panel_przegladania";
            this.Text = "Przeglądaj";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_review)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_show;
        private System.Windows.Forms.DataGridView dataGridView_review;
        private System.Windows.Forms.Button button_goback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.ComboBox comboBox_sort;
        private System.Windows.Forms.ComboBox comboBox_order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TypUzytkownika_label;
    }
}