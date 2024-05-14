using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMaket_project
{
    public partial class FormProducts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\DBSPMKT.mdf;Integrated Security = True;");
        public FormProducts()
            
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from SendProducts ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DisplayData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            cmd.CommandText = "Delete  From SendProducts where prodName='" + textprodName.Text + "'";
            cmd.ExecuteNonQuery();
            textprodName.Text = "";
            //comboBox2.Text = "";
            //textPrice.Text = "";
            //textBareCO.Text = "";
            //numbericdoQlty.Value = 0;
            //price = 0;
            //bareCode = 0;
            //qoulty = 0;
            con.Close();

            MessageBox.Show("Recods are deleted successfully");
            DisplayData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            cmd.CommandText = "Update SendProducts set prodName ='" + textprodName.Text + "' where prodName ='" + textSearch.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            textprodName.Text = "";
            //comboBox2.Text = "";
            //textPrice.Text = "";
            //textBareCO.Text = "";
            //numbericdoQlty.Value = 0;
            //price = 0;
            //bareCode = 0;
            //qoulty = 0;


            MessageBox.Show("Recods are update successfully");
            DisplayData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //int price = Convert.ToInt32(textPrice.Text);
            //int bareCode = Convert.ToInt32(textBarCO.Text);
            //int qoulty = Convert.ToInt32(textQoulty.Text);
            cmd.CommandText = "select * from SendProducts where prodName ='" + textSearch.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            textprodName.Text = "";
            //comboBox2.Text = "";
            //textPrice.Text = "";
            //textBareCO.Text = "";
            //numbericdoQlty.Value = 0;

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
