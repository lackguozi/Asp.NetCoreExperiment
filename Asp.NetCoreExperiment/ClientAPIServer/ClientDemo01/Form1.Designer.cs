﻿using GSWControls;

namespace ClientDemo01
{
    partial class Form1
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
            DBCondition dbCondition1 = new DBCondition();
            DBCondition dbCondition2 = new DBCondition();
            DBCondition dbCondition3 = new DBCondition();
            DBCondition dbCondition4 = new DBCondition();
            this.dbListBox1 = new DBListBox();
            this.dbCombox1 = new DBComBox();
            this.dataGridView1 = new DBDataGridView();
            this.DGTBC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTB_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTBC_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGTBC_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbListBox1
            // 
            dbCondition1.Name = "type";
            dbCondition1.Symbol = "=";
            dbCondition1.Value = "1";
            this.dbListBox1.Conditions.Add(dbCondition1);
            this.dbListBox1.DataSourceName = "city";
            this.dbListBox1.DisplayMember = "Value";
            this.dbListBox1.FormattingEnabled = true;
            this.dbListBox1.ItemHeight = 17;
            this.dbListBox1.Location = new System.Drawing.Point(12, 40);
            this.dbListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.dbListBox1.Name = "dbListBox1";
            this.dbListBox1.Size = new System.Drawing.Size(303, 89);
            this.dbListBox1.TabIndex = 0;
            this.dbListBox1.Url = "http://127.0.0.1:5235/parame/";
            this.dbListBox1.ValueMember = "Key";
            // 
            // dbCombox1
            // 
            dbCondition2.Name = "Category";
            dbCondition2.Symbol = "=";
            dbCondition2.Value = "1";
            this.dbCombox1.Conditions.Add(dbCondition2);
            this.dbCombox1.DataSourceName = "type";
            this.dbCombox1.DisplayMember = "Name";
            this.dbCombox1.FormattingEnabled = true;
            this.dbCombox1.Location = new System.Drawing.Point(12, 11);
            this.dbCombox1.Margin = new System.Windows.Forms.Padding(2);
            this.dbCombox1.Name = "dbCombox1";
            this.dbCombox1.Size = new System.Drawing.Size(303, 25);
            this.dbCombox1.TabIndex = 1;
            this.dbCombox1.Url = "http://127.0.0.1:5235/parame/";
            this.dbCombox1.ValueMember = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGTBC_ID,
            this.DGTB_Name,
            this.DGTBC_Price,
            this.DGTBC_Quantity});
            dbCondition3.Name = "Price";
            dbCondition3.Symbol = ">";
            dbCondition3.Value = "10";
            dbCondition4.Name = "Quantity";
            dbCondition4.Symbol = ">";
            dbCondition4.Value = "10";
            this.dataGridView1.Conditions.Add(dbCondition3);
            this.dataGridView1.Conditions.Add(dbCondition4);
            this.dataGridView1.DataSourceName = "order";
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(477, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Url = "http://127.0.0.1:5235/parame/";
            // 
            // DGTBC_ID
            // 
            this.DGTBC_ID.DataPropertyName = "ID";
            this.DGTBC_ID.HeaderText = "编号";
            this.DGTBC_ID.Name = "DGTBC_ID";
            // 
            // DGTB_Name
            // 
            this.DGTB_Name.DataPropertyName = "Name";
            this.DGTB_Name.HeaderText = "名称";
            this.DGTB_Name.Name = "DGTB_Name";
            // 
            // DGTBC_Price
            // 
            this.DGTBC_Price.DataPropertyName = "Price";
            this.DGTBC_Price.HeaderText = "价格";
            this.DGTBC_Price.Name = "DGTBC_Price";
            // 
            // DGTBC_Quantity
            // 
            this.DGTBC_Quantity.DataPropertyName = "Quantity";
            this.DGTBC_Quantity.HeaderText = "数量";
            this.DGTBC_Quantity.Name = "DGTBC_Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dbCombox1);
            this.Controls.Add(this.dbListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private DBListBox dbListBox1;
        private DBComBox dbCombox1;
        private DBDataGridView dataGridView1;
        private DataGridViewTextBoxColumn DGTBC_ID;
        private DataGridViewTextBoxColumn DGTBC_Name;
        private DataGridViewTextBoxColumn DGTBC_Price;
        private DataGridViewTextBoxColumn DGTBC_Quantity;
        private DataGridViewTextBoxColumn DGTB_Name;

        #endregion
        //private DBCombox dbCombox1;
    }
}