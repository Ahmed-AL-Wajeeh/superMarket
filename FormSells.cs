using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
namespace SuperMaket_project
{
    public partial class FormSells : Form
    {


        public FormSells()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\DBSPMKT.mdf;Integrated Security = True;");
        SqlDataReader rd;
        public void DisplayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from  ProductSells ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

          //textBoxAllQty.Text= (SqlDataAdapter sda2 = new SqlDataAdapter("Select ProdPrice * ProdQoulty from  ProductSells  " , con));

        }
        private void FormSells_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter sda2 = con.command("insert into ProductSells (ProdName,comBoProds,ProdBareCod,ProdPrice,ProdQoulty,ProdTotalQlty,Employees)  values( ' " + combSelectProds.Text + "' ,'" + comboBox2.Text + "' , '" + barecode + "' , '" + price + "' , '" + qty + "','" + totalqlty + "','" + comEmployees.Text + "') ");
            //int qty = Convert.ToInt32(numbericdoQlty.Value);
            //int price = Convert.ToInt32(textBoxPrice.Text);
            //int barecode = Convert.ToInt32(textBoxBCode.Text);
            //int totalqlty = qty * price;
            //textBoxAllQty.Text = (Convert.ToInt32(textBoxAllQty.Text) + totalqlty + "");
            SqlDataReader rd;
            con.Open();
            string sql = "select * From  LoginUsers ";
            //string sql = "select * From SendProducts ";

            SqlCommand cmd = new SqlCommand(sql, con);

            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //combSelectProds.Items.Add(rd["ProdName"]);
                comEmployees.Items.Add(rd["UserName"]);
            }
            con.Close();

            this.dataGridView1.ColumnHeadersHeight =100;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           
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
            //cmd.CommandText = "select * from ProductSells where Prod_id ='" + textSearch.Text + "'";
            cmd.CommandText = "select * from ProductSells where ProdName ='" + textSearch.Text + "'";
            //cmd.CommandText = "select * from ProductSells where comBoProds ='" + textSearch.Text + "'";
            //cmd.CommandText = "select * from ProductSells where ProdBareCod ='" + textSearch.Text + "'";
            //cmd.CommandText = "select * from ProductSells where ProdPrice ='" + textSearch.Text + "'";
            //cmd.CommandText = "select * from ProductSells where ProdQoulty ='" + textSearch.Text + "'";
            //cmd.CommandText = "select * from ProductSells where ProdTotalQlty ='" + textSearch.Text + "'";
            //cmd.CommandText = "select * from ProductSells where Employees ='" + textSearch.Text + "'";


            cmd.ExecuteNonQuery();
            textSearch.Text = "";
            con.Close();

           

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 45;
         
            Font f = new Font("Arial", 18, FontStyle.Bold);
            string strnameSuper = "سوبر ماركت";
            string stName = "تقرير مبيعات";
            SizeF fontsizeNameSuper = e.Graphics.MeasureString(strnameSuper, f);
            SizeF fontsizeName = e.Graphics.MeasureString(stName, f);

            e.Graphics.DrawString(strnameSuper, f, Brushes.Blue, (e.PageBounds.Width - fontsizeNameSuper.Width) - margin, margin );
            e.Graphics.DrawString(stName, f, Brushes.Navy, e.PageBounds.Width - fontsizeName.Width - margin, margin+ fontsizeNameSuper.Height);
            float preHights = margin +  fontsizeNameSuper.Height + 50;
            e.Graphics.DrawRectangle(Pens.Black, margin, preHights, e.PageBounds.Width - margin * 2, e.PageBounds.Height * 2 - preHights * 2);

            float colHight = 50;
            float col1width = 50;
            float col2width = 120 + col1width;
            float col3width = 100 + col2width;
            float col4width = 100 + col3width;
            float col5width = 120 + col4width;
            float col6width = 100 + col5width;
            float colsptotal = 160 + col6width;
            SolidBrush sb = new SolidBrush(Color.Blue);

            e.Graphics.DrawLine(Pens.Black, margin, preHights + colHight, e.PageBounds.Width - margin, preHights + colHight);
            e.Graphics.DrawString("الرقم", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHights);
           

            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preHights, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin);
            e.Graphics.DrawString("الصنف", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preHights, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الوحدة", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preHights, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col4width, preHights, e.PageBounds.Width - margin * 2 - col4width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الباركود", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col5width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col5width, preHights, e.PageBounds.Width - margin * 2 - col5width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col6width, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col6width, preHights, e.PageBounds.Width - margin * 2 - col6width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("الاجمالي", f, Brushes.Black, e.PageBounds.Width - margin / 2 - 1 - colsptotal, preHights);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colsptotal, preHights, e.PageBounds.Width - margin * 2 - colsptotal, e.PageBounds.Height - margin);



            float rowsHeight = 60;
            for (int x = 0; x < dataGridView1.Rows.Count; x += 1)
            {
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[0].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 +4 - col1width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2  - col2width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[4].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2  - col5width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[5].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 +4 - col6width, preHights + rowsHeight);
                e.Graphics.DrawString(dataGridView1.Rows[x].Cells[6].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin / 2 + 4 - colsptotal, preHights + rowsHeight);

               
                e.Graphics.DrawLine(Pens.Black, margin, preHights + rowsHeight + colHight, e.PageBounds.Width - margin, preHights + rowsHeight + colHight);


                rowsHeight += 60;
            }
            //e.Graphics.DrawString("الاجمالي", f, Brushes.Blue, e.PageBounds.Width - margin * 2 + 1 - col5width, preHights + rowsHeight);
            //e.Graphics.DrawString(textBoxAllQty.Text, f, Brushes.Green, e.PageBounds.Width - margin / 2 + 4 - colsptotal, preHights + rowsHeight);
            //e.Graphics.DrawLine(Pens.Black, margin, preHights + rowsHeight + colHight, e.PageBounds.Width - margin, preHights + rowsHeight + colHight);

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void textBoxAllQty_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * From ProductSells where Prod_id=  ProdTotalQlty * Prod_id   ";
            //string sql = "select * From SendProducts ";

            SqlCommand cmd = new SqlCommand(sql, con);
            int Allqoulty = Convert.ToInt32(textBoxAllQty.Text);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                object v = rd[textBoxAllQty.Text = sql];
                object p = textBoxAllQty.Text.Count((Func<char, bool>)v);
                //textBoxAllQty.Text.Count((Func<char, bool>)rd["'ProdTotalQlty * Prod_id'"]);
                //comEmployees.Items.Add(rd["UserName"]);
            }
            con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //ndText = "Update ProductSells set ProdName ='" + textProdName.Text + "' ,FullName='" + combProd.Text + "' ,Address='" + txtAddress.Text + "' ,Phone='" + txtPhone.Text + "' ,Password='" + textPass.Text + "'where User_id='" + textuser_id.Text + "' ";

            ////cmd.Com
            //SqlDataAdapter sda = con.command("insert into ProductSells (ProdName,comBoProds,ProdBareCod,ProdPrice,ProdQoulty,ProdTotalQlty,Employees)  values( ' " + combSelectProds.Text + "' ,'" + comboBox2.Text + "' , '" + barecode + "' , '" + price + "' , '" + qty + "','" + totalqlty + "','" + comEmployees.Text + "') ");
            int qty = Convert.ToInt32(numbericdoQlty.Value);
            int price = Convert.ToInt32(textBoxPrice.Text);
            int barecode = Convert.ToInt32(textBoxBCode.Text);
            int totalqlty = qty * price;
            textBoxAllQty.Text = (Convert.ToInt32(textBoxAllQty.Text) + totalqlty + "");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //int userid = Convert.ToInt32(textuser_id.Text);
            cmd.CommandText = "Update ProductSells set ProdName ='" + textProdName.Text + "' ,comBoProds='" + combProd.Text + "' ,ProdBareCod='" + textBoxBCode.Text + "' ,ProdPrice='" + textBoxPrice.Text + "' ,ProdQoulty='" + numbericdoQlty.Value + "' ,ProdTotalQlty='" + totalqlty + "' ,Employees = '" + comEmployees.Text + "'where Prod_id='" + textProd_id.Text + "' ";
            //cmd.CommandText = "Update LoginUsers set UserName ='" + txtUserName.Text + "' where UserName ='" + textUpdate.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            


            MessageBox.Show("Recods are update successfully");
            DisplayData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex <= dataGridView1.RowCount & e.ColumnIndex >= 0 & e.ColumnIndex <= dataGridView1.ColumnCount)
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    textProd_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textProdName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    combProd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBoxBCode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string numberiQlty = Convert.ToString(numbericdoQlty.Value);
                    numberiQlty = dataGridView1.Rows[e.RowIndex].Cells[5].ValueType.ToString();
                    comEmployees.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                }
        }

        private void textProd_id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textProdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBoxBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
    }
}
