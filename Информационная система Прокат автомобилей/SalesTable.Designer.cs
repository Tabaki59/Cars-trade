namespace Информационная_система_Прокат_автомобилей
{
    partial class SalesTable
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
            this.Exit = new System.Windows.Forms.Button();
            this.End_sale = new System.Windows.Forms.Button();
            this.Rent_Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Rent_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(12, 559);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(758, 32);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // End_sale
            // 
            this.End_sale.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.End_sale.Location = new System.Drawing.Point(12, 516);
            this.End_sale.Name = "End_sale";
            this.End_sale.Size = new System.Drawing.Size(758, 37);
            this.End_sale.TabIndex = 8;
            this.End_sale.Text = "Закрыть сделку";
            this.End_sale.UseVisualStyleBackColor = true;
            this.End_sale.Click += new System.EventHandler(this.End_sale_Click);
            // 
            // Rent_Table
            // 
            this.Rent_Table.AllowUserToAddRows = false;
            this.Rent_Table.AllowUserToDeleteRows = false;
            this.Rent_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rent_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.Rent_Table.Location = new System.Drawing.Point(12, 13);
            this.Rent_Table.Name = "Rent_Table";
            this.Rent_Table.ReadOnly = true;
            this.Rent_Table.RowTemplate.Height = 24;
            this.Rent_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rent_Table.Size = new System.Drawing.Size(758, 497);
            this.Rent_Table.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер сделки";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Госномер";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер и серия паспорта";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Статус сделки";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Срок сделки";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Сумма сделки";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SalesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.ControlBox = false;
            this.Controls.Add(this.Rent_Table);
            this.Controls.Add(this.End_sale);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "SalesTable";
            this.Text = "Таблица сделок";
            ((System.ComponentModel.ISupportInitialize)(this.Rent_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерИСерияПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDСтатусаСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаСделкиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView Rent_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Button End_sale;
    }
}