namespace Library_K300
{
    partial class BookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.TxtCounts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbAuthors = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPublish = new System.Windows.Forms.DateTimePicker();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBooks
            // 
            this.dtgBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBooks.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBooks.Location = new System.Drawing.Point(282, 12);
            this.dtgBooks.Name = "dtgBooks";
            this.dtgBooks.Size = new System.Drawing.Size(506, 426);
            this.dtgBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(18, 82);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(172, 26);
            this.txtBookName.TabIndex = 2;
            // 
            // TxtCounts
            // 
            this.TxtCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCounts.Location = new System.Drawing.Point(18, 239);
            this.TxtCounts.Name = "TxtCounts";
            this.TxtCounts.Size = new System.Drawing.Size(172, 26);
            this.TxtCounts.TabIndex = 4;
            this.TxtCounts.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.TxtCounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCounts_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Counts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Authors";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CmbAuthors
            // 
            this.CmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAuthors.FormattingEnabled = true;
            this.CmbAuthors.Location = new System.Drawing.Point(18, 161);
            this.CmbAuthors.Name = "CmbAuthors";
            this.CmbAuthors.Size = new System.Drawing.Size(172, 28);
            this.CmbAuthors.TabIndex = 6;
            this.CmbAuthors.SelectedIndexChanged += new System.EventHandler(this.CmbAuthors_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publish Date";
            // 
            // dtPublish
            // 
            this.dtPublish.Location = new System.Drawing.Point(18, 289);
            this.dtPublish.Name = "dtPublish";
            this.dtPublish.Size = new System.Drawing.Size(172, 20);
            this.dtPublish.TabIndex = 8;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBook.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddBook.Location = new System.Drawing.Point(18, 359);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(172, 43);
            this.BtnAddBook.TabIndex = 9;
            this.BtnAddBook.Text = "Add Books";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblError.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(10, 420);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(148, 33);
            this.LblError.TabIndex = 10;
            this.LblError.Text = "Publish Date";
            this.LblError.Visible = false;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.dtPublish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbAuthors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgBooks);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox TxtCounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbAuthors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPublish;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Label LblError;
    }
}