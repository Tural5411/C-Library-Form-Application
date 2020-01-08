using Library_K300.Models;
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
    public partial class BookForm : Form
    {
        LibDB db = new LibDB();
        public BookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

            BookLoad();

            CmbAuthors.Items.AddRange(db.Authors.Select(ath => ath.AuthorName).ToArray());
        }

        public void BookLoad()
        {
            dtgBooks.DataSource = db.Books.Select(bk => new {
                bk.Bookname,
                bk.Counts,
                bk.Author.AuthorName,
                bk.CreateDate
            })
                .ToList();
        }

        private void CmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            string bkname =txtBookName.Text;
            string count = TxtCounts.Text;
            string authorname = CmbAuthors.Text;
            DateTime publishdate = dtPublish.Value;

            if (bkname != string.Empty && count != string.Empty
                && authorname != string.Empty && publishdate <= DateTime.Now)
            {

                int AutId = db.Authors.First(ath => ath.AuthorName == authorname).Id;
                int countNum = Convert.ToInt32(count);
                Book bk = new Book();
                bk.Bookname = bkname;
                bk.Counts = countNum;
                bk.AuthorId = AutId;
                bk.CreateDate = publishdate;
                db.Books.Add(bk);
                db.SaveChanges();
                BookLoad();
                MessageBox.Show("Book succesfuly", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                LblError.Text = "Please All the fill!";
                LblError.Visible = true;
            }
        }

   
        private void TxtCounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar!=8)
            {
                e.Handled=true;
            }
        }
    }
}
