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
using System.Configuration;

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
            // TODO: This line of code loads data into the 'mssql2003115DataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.mssql2003115DataSet.Assets);

        }

        private void connectionBox_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void assetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assetsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mssql2003115DataSet);

        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2003115; User ID = mssql2003115; Password = pAK3EFv2db";

            conn = new SqlConnection(connString);
            conn.Open();


            string query = "";
            var Insert1 = "";
            var Insert2 = "";
            var Insert3 = "";
            var Insert4 = "";
            var Insert5 = "";
            var Insert6 = "";
            var Insert7 = "";
            var Insert8 = "";

            Insert1 = assetIDTextBox.Text;
            Insert2 = systemNameTextBox.Text;
            Insert3 = modelTextBox.Text;
            Insert4 = manufacturerTextBox.Text;
            Insert5 = typeTextBox.Text;
            Insert6 = iPAddressTextBox.Text;
            Insert7 = purchaseDateDateTimePicker.Text;
            Insert8 = noteTextBox.Text;

            query = "INSERT INTO [mssql2003115].[dbo].[Assets] VALUES ('" + Insert1 + "' , '" + Insert2 + "' , '" + Insert3 + "' , '" + Insert4 + "' , '" + Insert5 + "' , '" + Insert6 + "' , '" + Insert7 + "' ,'" + Insert8 + "')";

            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            SqlDataReader data = command.ExecuteReader();
            MessageBox.Show("Asset Created with ID: " + Insert1 + ".");
            conn.Close();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2003115; User ID = mssql2003115; Password = pAK3EFv2db";

            conn = new SqlConnection(connString);
            conn.Open();

            string query = "";
            int ID = assetsDataGridView.CurrentCell.RowIndex + 1;

            query = "DELETE FROM [mssql2003115].[dbo].[Assets] WHERE AssetID = '"+ ID +  "'";
            
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            SqlDataReader data = command.ExecuteReader();
            conn.Close();

            assetsDataGridView.Rows.RemoveAt(ID);
        }
            
    }
}
