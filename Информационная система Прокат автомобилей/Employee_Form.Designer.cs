namespace Информационная_система_Прокат_автомобилей
{
    partial class Employee_Form
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
            this.Open_List = new System.Windows.Forms.Button();
            this.Sprav_button = new System.Windows.Forms.Button();
            this.Del_filters = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Automobl = new System.Windows.Forms.Button();
            this.Confirm_trade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabel_auto_for_others = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otmena_trade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabel_auto_for_others)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rent_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_List
            // 
            this.Open_List.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Open_List.Location = new System.Drawing.Point(388, 664);
            this.Open_List.Name = "Open_List";
            this.Open_List.Size = new System.Drawing.Size(862, 78);
            this.Open_List.TabIndex = 15;
            this.Open_List.Text = "Открыть список сделок";
            this.Open_List.UseVisualStyleBackColor = true;
            this.Open_List.Click += new System.EventHandler(this.Open_List_Click);
            // 
            // Sprav_button
            // 
            this.Sprav_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Sprav_button.Location = new System.Drawing.Point(12, 748);
            this.Sprav_button.Name = "Sprav_button";
            this.Sprav_button.Size = new System.Drawing.Size(1238, 40);
            this.Sprav_button.TabIndex = 14;
            this.Sprav_button.Text = "Справка";
            this.Sprav_button.UseVisualStyleBackColor = true;
            this.Sprav_button.Click += new System.EventHandler(this.Sprav_button_Click);
            // 
            // Del_filters
            // 
            this.Del_filters.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Del_filters.Location = new System.Drawing.Point(12, 706);
            this.Del_filters.Name = "Del_filters";
            this.Del_filters.Size = new System.Drawing.Size(370, 36);
            this.Del_filters.TabIndex = 13;
            this.Del_filters.Text = "Cбросить фильтр";
            this.Del_filters.UseVisualStyleBackColor = true;
            this.Del_filters.Click += new System.EventHandler(this.Del_filters_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(12, 794);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(1238, 52);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Search.Location = new System.Drawing.Point(12, 664);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(370, 36);
            this.Search.TabIndex = 11;
            this.Search.Text = "Поиск по фильтру";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Automobl
            // 
            this.Automobl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Automobl.Location = new System.Drawing.Point(12, 539);
            this.Automobl.Name = "Automobl";
            this.Automobl.Size = new System.Drawing.Size(1238, 37);
            this.Automobl.TabIndex = 16;
            this.Automobl.Text = "Выдать автомобиль";
            this.Automobl.UseVisualStyleBackColor = true;
            this.Automobl.Click += new System.EventHandler(this.Automobl_Click);
            // 
            // Confirm_trade
            // 
            this.Confirm_trade.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Confirm_trade.Location = new System.Drawing.Point(12, 582);
            this.Confirm_trade.Name = "Confirm_trade";
            this.Confirm_trade.Size = new System.Drawing.Size(1238, 35);
            this.Confirm_trade.TabIndex = 17;
            this.Confirm_trade.Text = "Подтвердить сделку";
            this.Confirm_trade.UseVisualStyleBackColor = true;
            this.Confirm_trade.Click += new System.EventHandler(this.Confirm_trade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Список авто в наличии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(13, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Список сделок \"На рассмотрении\"";
            // 
            // Tabel_auto_for_others
            // 
            this.Tabel_auto_for_others.AllowUserToAddRows = false;
            this.Tabel_auto_for_others.AllowUserToDeleteRows = false;
            this.Tabel_auto_for_others.AllowUserToResizeColumns = false;
            this.Tabel_auto_for_others.AllowUserToResizeRows = false;
            this.Tabel_auto_for_others.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabel_auto_for_others.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.Tabel_auto_for_others.Location = new System.Drawing.Point(12, 43);
            this.Tabel_auto_for_others.Name = "Tabel_auto_for_others";
            this.Tabel_auto_for_others.ReadOnly = true;
            this.Tabel_auto_for_others.RowTemplate.Height = 24;
            this.Tabel_auto_for_others.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabel_auto_for_others.Size = new System.Drawing.Size(1238, 252);
            this.Tabel_auto_for_others.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Госномер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Модель";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Тип кузова";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Тип коробки";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Тип привода";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Объем двигателя";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Расход на 100 км";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Состояние авто";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Год выпуска";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Количество мест";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Вместимость багажника";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Тип топлива";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Тип страховки";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Цена за сутки";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Тип двигателя";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Класс автомобиля";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Rent_Table
            // 
            this.Rent_Table.AllowUserToAddRows = false;
            this.Rent_Table.AllowUserToDeleteRows = false;
            this.Rent_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rent_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column17,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.Rent_Table.Location = new System.Drawing.Point(12, 334);
            this.Rent_Table.Name = "Rent_Table";
            this.Rent_Table.ReadOnly = true;
            this.Rent_Table.RowTemplate.Height = 24;
            this.Rent_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rent_Table.Size = new System.Drawing.Size(1238, 199);
            this.Rent_Table.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер сделки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Госномер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер и серия паспорта";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Статус сделкм";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Срок сделки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма сделки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Otmena_trade
            // 
            this.Otmena_trade.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Otmena_trade.Location = new System.Drawing.Point(12, 623);
            this.Otmena_trade.Name = "Otmena_trade";
            this.Otmena_trade.Size = new System.Drawing.Size(1238, 35);
            this.Otmena_trade.TabIndex = 31;
            this.Otmena_trade.Text = "Отменить сделку";
            this.Otmena_trade.UseVisualStyleBackColor = true;
            this.Otmena_trade.Click += new System.EventHandler(this.Otmena_trade_Click);
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.ControlBox = false;
            this.Controls.Add(this.Otmena_trade);
            this.Controls.Add(this.Rent_Table);
            this.Controls.Add(this.Tabel_auto_for_others);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm_trade);
            this.Controls.Add(this.Automobl);
            this.Controls.Add(this.Open_List);
            this.Controls.Add(this.Sprav_button);
            this.Controls.Add(this.Del_filters);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "Employee_Form";
            this.Text = "Окно сотрудника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Tabel_auto_for_others)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rent_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_List;
        private System.Windows.Forms.Button Sprav_button;
        private System.Windows.Forms.Button Del_filters;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Automobl;
        private System.Windows.Forms.Button Confirm_trade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView Tabel_auto_for_others;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        public System.Windows.Forms.DataGridView Rent_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Otmena_trade;
    }
}