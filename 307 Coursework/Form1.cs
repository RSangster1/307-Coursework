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
using System.Data.SqlTypes;

namespace _307_Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {


                SqlConnection conn;

                string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2003115; User ID = mssql2003115; Password = pAK3EFv2db";

                conn = new SqlConnection(connString);

                conn.Open();


                string query = "SELECT Employee_ID FROM [mssql2003115].[dbo].[Comic.STAFF]";

                SqlCommand command = new SqlCommand(query);

                command.Connection = conn;

                SqlDataReader data = command.ExecuteReader();


                while (data.Read())
                {

                    connectionBox.Checked = true;

                }
                data.Close();

                conn.Close();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void connectionBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();

            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2003115; User ID = mssql2003115; Password = pAK3EFv2db";

            conn = new SqlConnection(connString);

            SqlDataAdapter da = new SqlDataAdapter("Select * from[mssql2003115].[dbo].[Assets]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Assets");
            dataGridView1.DataSource = ds.Tables["Assets"].DefaultView;




            

          
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
