using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_K300
{
    public partial class AddReaders : Form
    {
        public AddReaders()
        {
            InitializeComponent();
        }

        private void AddReaders_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.libCon))
            {
                string comQuery = "Select FacultyName from Faculties";
                SqlCommand com = new SqlCommand(comQuery,con);
                con.Open();
                var rd = com.ExecuteReader();
                while (rd.Read())
                {

                    CmbFaculty.Items.Add(rd.GetValue(0).ToString());
                          
                }
            }





            //CmbFaculty.Items.Add("Iqtisadiyyat");
            //CmbFaculty.Items.Add("Marketing");
            //CmbFaculty.Items.Add("Cografiya");
            //CmbFaculty.Items.Add("Huquq");
            //CmbFaculty.Items.Add("Serqsunasliq");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReader_Click(object sender, EventArgs e)
        {
            string firstname = TxtFirstname.Text;
            string lastname = TxtLastname.Text;
            string phone = TxtPhone.Text;
            string faculty = CmbFaculty.Text;
            long newphone;

            if(firstname != "" && lastname!="" && phone!="" && faculty != "" )
            {
                if(long.TryParse(phone,out newphone))
                {
                    using (SqlConnection con = new SqlConnection(Properties.Settings.Default.libCon))
                    {
                        string comQuery = $"Insert into Readers Values('{firstname}','{lastname}','{phone}',{2}) ";
                        SqlCommand comm = new SqlCommand(comQuery, con);
                        con.Open();

                        int result = comm.ExecuteNonQuery();
                        if (result >= 1)
                        {
                            MessageBox.Show($"{firstname} war created succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    
                    }
                    
                    

                }
                else
                {
                    MessageBox.Show("Phone should be numeric chracter!","ERRROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Butun xanalari doldurun","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
