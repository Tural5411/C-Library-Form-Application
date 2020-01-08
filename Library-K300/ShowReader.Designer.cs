namespace Library_K300
{
    partial class ShowReader
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
            this.dtgReaders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReaders
            // 
            this.dtgReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReaders.Location = new System.Drawing.Point(25, 29);
            this.dtgReaders.Name = "dtgReaders";
            this.dtgReaders.Size = new System.Drawing.Size(728, 396);
            this.dtgReaders.TabIndex = 0;
            this.dtgReaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReaders_CellContentClick);
            // 
            // ShowReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgReaders);
            this.Name = "ShowReader";
            this.Text = "ShowReader";
            this.Load += new System.EventHandler(this.ShowReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgReaders;
    }
}