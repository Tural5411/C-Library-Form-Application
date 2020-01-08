using Library_K300.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_K300
{
    public partial class ShowReader : Form
    {
        public ShowReader()
        {
            InitializeComponent();
        }

        private void ShowReader_Load(object sender, EventArgs e)
        {
    


            LibDB db = new LibDB();
            dtgReaders.DataSource = db.Readers.Select(rs => new
            {
                rs.FirstName,
                rs.LastName,
                rs.Phono,
                rs.Faculty.FacultyName
            }).ToList();
            
        }

        private void dtgReaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


                    