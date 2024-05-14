
namespace SuperMaket_project
{
    partial class FormSells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSells));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxAllQty = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label11 = new System.Windows.Forms.Label();
            this.comEmployees = new System.Windows.Forms.ComboBox();
            this.combProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.numbericdoQlty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textProd_id = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new SuperMaket_project.LODBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericdoQlty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1511, 456);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Green;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Location = new System.Drawing.Point(385, 79);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 42);
            this.buttonSearch.TabIndex = 40;
            this.buttonSearch.Text = "بحث";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(23, 80);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(346, 42);
            this.textSearch.TabIndex = 39;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Green;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPrint.Location = new System.Drawing.Point(23, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(195, 47);
            this.buttonPrint.TabIndex = 41;
            this.buttonPrint.Text = "طباعة";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // textBoxAllQty
            // 
            this.textBoxAllQty.BackColor = System.Drawing.Color.Aqua;
            this.textBoxAllQty.Location = new System.Drawing.Point(711, 64);
            this.textBoxAllQty.Multiline = true;
            this.textBoxAllQty.Name = "textBoxAllQty";
            this.textBoxAllQty.ReadOnly = true;
            this.textBoxAllQty.Size = new System.Drawing.Size(139, 38);
            this.textBoxAllQty.TabIndex = 43;
            this.textBoxAllQty.Text = "0";
            this.textBoxAllQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAllQty.TextChanged += new System.EventHandler(this.textBoxAllQty_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(520, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 44;
            this.button1.Text = "تحديث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(1129, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = ":الموظف";
            // 
            // comEmployees
            // 
            this.comEmployees.FormattingEnabled = true;
            this.comEmployees.Location = new System.Drawing.Point(888, 120);
            this.comEmployees.MinimumSize = new System.Drawing.Size(50, 0);
            this.comEmployees.Name = "comEmployees";
            this.comEmployees.Size = new System.Drawing.Size(223, 27);
            this.comEmployees.TabIndex = 56;
            // 
            // combProd
            // 
            this.combProd.FormattingEnabled = true;
            this.combProd.Items.AddRange(new object[] {
            "single",
            "package"});
            this.combProd.Location = new System.Drawing.Point(888, 17);
            this.combProd.MinimumSize = new System.Drawing.Size(50, 0);
            this.combProd.Name = "combProd";
            this.combProd.Size = new System.Drawing.Size(223, 27);
            this.combProd.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(743, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = ":الإجمالي";
            // 
            // textBoxBCode
            // 
            this.textBoxBCode.Location = new System.Drawing.Point(888, 71);
            this.textBoxBCode.Multiline = true;
            this.textBoxBCode.Name = "textBoxBCode";
            this.textBoxBCode.Size = new System.Drawing.Size(223, 41);
            this.textBoxBCode.TabIndex = 50;
            this.textBoxBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBCode_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1129, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = ":الوحدة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(1467, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = ":السعر";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(1461, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = ": الصنف";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(1232, 62);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(223, 40);
            this.textBoxPrice.TabIndex = 61;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // numbericdoQlty
            // 
            this.numbericdoQlty.Location = new System.Drawing.Point(1232, 118);
            this.numbericdoQlty.Name = "numbericdoQlty";
            this.numbericdoQlty.Size = new System.Drawing.Size(223, 27);
            this.numbericdoQlty.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1467, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = ":الكمية ";
            // 
            // textProdName
            // 
            this.textProdName.Location = new System.Drawing.Point(1232, 12);
            this.textProdName.Multiline = true;
            this.textProdName.Name = "textProdName";
            this.textProdName.Size = new System.Drawing.Size(223, 41);
            this.textProdName.TabIndex = 63;
            this.textProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textProdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProdName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1129, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = ":الباركود";
            // 
            // buttonDelet
            // 
            this.buttonDelet.BackColor = System.Drawing.Color.Green;
            this.buttonDelet.FlatAppearance.BorderSize = 0;
            this.buttonDelet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelet.Location = new System.Drawing.Point(236, 14);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(191, 42);
            this.buttonDelet.TabIndex = 67;
            this.buttonDelet.Text = "حذف";
            this.buttonDelet.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Green;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.Location = new System.Drawing.Point(448, 14);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(195, 42);
            this.buttonUpdate.TabIndex = 66;
            this.buttonUpdate.Text = "تعديل";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textProd_id
            // 
            this.textProd_id.Location = new System.Drawing.Point(1232, 12);
            this.textProd_id.Multiline = true;
            this.textProd_id.Name = "textProd_id";
            this.textProd_id.Size = new System.Drawing.Size(223, 41);
            this.textProd_id.TabIndex = 68;
            this.textProd_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textProd_id.Visible = false;
            this.textProd_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProd_id_KeyPress);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.SendProductsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SuperMaket_project.LODBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1535, 629);
            this.Controls.Add(this.textProd_id);
            this.Controls.Add(this.buttonDelet);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.numbericdoQlty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProdName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comEmployees);
            this.Controls.Add(this.combProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAllQty);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSells";
            this.Text = "FormSells";
            this.Load += new System.EventHandler(this.FormSells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericdoQlty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxAllQty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comEmployees;
        private System.Windows.Forms.ComboBox combProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.NumericUpDown numbericdoQlty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textProd_id;
        private LODBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}