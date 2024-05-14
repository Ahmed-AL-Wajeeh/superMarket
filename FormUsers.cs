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
    public partial class FormUsers : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\DBSPMKT.mdf;Integrated Security = True;");
        //connection con = new connection();
        public FormUsers()
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            //DataTable dt = new DataTable();
            ////SqlDataAdapter sda = con.command("Select * from  LoginUsers ");
            //SqlDataAdapter sda = new SqlDataAdapter("Select * from  LoginUsers ",con);
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DisplayData();
           
        }

        private void buttonUPdate_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUSR_Click(object sender, EventArgs e)
        {

            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //int phone = Convert.ToInt32(txtPhone.Text);
            ////int emial = Convert.ToInt32(.Text);
            //cmd.CommandText = "insert into LoginUsers (UserName,FullName,Address,Phone,Password)  values( ' " + txtUserName.Text + "' ,'" + txtFullName.Text + "' , '" + txtAddress.Text + "' ,  '" + phone + "','" + textPass.Text + "') ";
            //cmd.ExecuteNonQuery();
            ////DataTable dt = new DataTable();
            ////SqlDataAdapter sda = con.command("insert into LoginUsers(UserName, FullName, Address, Phone, Password)  values(' " + txtUserName.Text + "', '" + txtFullName.Text + "', '" + txtAddress.Text + "', '" + phone+ "', '" + textPass.Text + "') ");
            //txtUserName.Text = "";
            //txtFullName.Text = "";
            //txtAddress.Text = "";
            ////txtEmail.Text = "";
            //phone = 0;
            //textPass.Text = "";


            //con.Close();

            //MessageBox.Show("Recods are entered successfully");
            //    DisplayData();
    }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // con.Open();
           // SqlCommand cmd = con.CreateCommand();
           // cmd.CommandType = CommandType.Text;
           // //int userid = Convert.ToInt32(textuser_id.Text);
           // cmd.CommandText = "Update LoginUsers set UserName ='" + txtUserName.Text + "' ,FullName='" + txtFullName.Text + "' ,Address='" + txtAddress.Text + "' ,Phone='"+txtPhone.Text+"' ,Password='" + textPass.Text + "'where User_id='"+textuser_id.Text+"' ";

           // //cmd.CommandText = "Update LoginUsers set UserName ='" + txtUserName.Text + "' FullName='"+txtFullName.Text+ "'Address='" + txtAddress.Text+ "'Password='" + textPass.Text+"' where UserName ='" + txtUserName.Text + "'FullName='" + txtFullName.Text + "'Address='" + txtAddress.Text + "' Password='"+ textPass.Text+ "'";
           // //cmd.CommandText = "Update LoginUsers set UserName ='" + txtUserName.Text + "' where UserName ='" + textUpdate.Text + "'";

           // cmd.ExecuteNonQuery();
           // con.Close();
           // //DataTable dt = new DataTable();
           // //SqlDataAdapter sda = con.command( "Update LoginUsers set UserName ='" + txtUserName.Text + "' where UserName ='" + textUpdate.Text + "'");
           // txtUserName.Text = "";
           
          
           //MessageBox.Show("Recods are update successfully");
           // DisplayData();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
        
            //cmd.CommandText = "Delete From LoginUsers where UserName ='" + txtUserName.Text + "'";
            //cmd.ExecuteNonQuery();
            //con.Close();
            ////DataTable dt = new DataTable();
            ////SqlDataAdapter sda = con.command("Delete From LoginUsers where UserName ='" + txtUserName.Text + "'");

            //txtUserName.Text = "";
         

            ////price = 0;
            ////bareCode = 0;
            ////qoulty = 0;


            //MessageBox.Show("Recods are Delete successfully");
            //DisplayData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex>=0&e.RowIndex<=dataGridView1.RowCount)
                if (dataGridView1.Rows[e.RowIndex] != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textuser_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

              

            }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+e.RowIndex);
            }
            
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
               e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar)  )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFullName.Focus();
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textPass.Focus();
            }
        }
    }
}
