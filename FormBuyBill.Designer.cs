namespace SuperMaket_project
{
    partial class FormBuyBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbuyBill_id = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textSupplier_id = new System.Windows.Forms.TextBox();
            this.textEmployee_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGVBuyBill = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBuyBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(846, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = ":الرقم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = ":تاريخ الشراء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = ":السعر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = ":رقم المورد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = ":رقم الموظف";
            // 
            // textbuyBill_id
            // 
            this.textbuyBill_id.Location = new System.Drawing.Point(771, 68);
            this.textbuyBill_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbuyBill_id.Multiline = true;
            this.textbuyBill_id.Name = "textbuyBill_id";
            this.textbuyBill_id.Size = new System.Drawing.Size(72, 29);
            this.textbuyBill_id.TabIndex = 5;
            this.textbuyBill_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(356, 68);
            this.textPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPrice.Multiline = true;
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(108, 28);
            this.textPrice.TabIndex = 6;
            // 
            // textSupplier_id
            // 
            this.textSupplier_id.Location = new System.Drawing.Point(183, 68);
            this.textSupplier_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSupplier_id.Multiline = true;
            this.textSupplier_id.Name = "textSupplier_id";
            this.textSupplier_id.Size = new System.Drawing.Size(85, 28);
            this.textSupplier_id.TabIndex = 7;
            // 
            // textEmployee_id
            // 
            this.textEmployee_id.Location = new System.Drawing.Point(4, 66);
            this.textEmployee_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEmployee_id.Multiline = true;
            this.textEmployee_id.Name = "textEmployee_id";
            this.textEmployee_id.Size = new System.Drawing.Size(83, 29);
            this.textEmployee_id.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 72);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.label6);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(906, 39);
            this.panelHeader.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(427, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "فاتورة شراء";
            // 
            // dataGVBuyBill
            // 
            this.dataGVBuyBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVBuyBill.Location = new System.Drawing.Point(0, 113);
            this.dataGVBuyBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGVBuyBill.Name = "dataGVBuyBill";
            this.dataGVBuyBill.RowHeadersWidth = 62;
            this.dataGVBuyBill.RowTemplate.Height = 29;
            this.dataGVBuyBill.Size = new System.Drawing.Size(905, 284);
            this.dataGVBuyBill.TabIndex = 11;
            // 
            // FormBuyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(906, 398);
            this.Controls.Add(this.dataGVBuyBill);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textEmployee_id);
            this.Controls.Add(this.textSupplier_id);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textbuyBill_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBuyBill";
            this.Text = "FormBuyBill";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBuyBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbuyBill_id;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textSupplier_id;
        private System.Windows.Forms.TextBox textEmployee_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGVBuyBill;
    }
}