using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_K300
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgMain.Image = new Bitmap(@"C:\Users\User\source\repos\Library-K300\Library-K300\img\lib2.png");
            imgMain.Location = new Point((this.ClientSize.Width-imgMain.Size.Width)/2,
               (this.ClientSize.Height - imgMain.Size.Height) / 2 ) ;
        }

        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReaders adr = new AddReaders();
            adr.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReader sr = new ShowReader();
            sr.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bkf = new BookForm();
            bkf.ShowDialog ();
        }
    }
}
