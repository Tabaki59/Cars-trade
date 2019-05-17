namespace Информационная_система_Прокат_автомобилей
{
    partial class Admin_Form
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
            this.Add_Auto = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Sprav_button = new System.Windows.Forms.Button();
            this.Del_filters = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Change_auto = new System.Windows.Forms.Button();
            this.Open_Client_table = new System.Windows.Forms.Button();
            this.Open_Sdel_Table = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Tabel_auto_for_admin = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.Tabel_auto_for_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Auto
            // 
            this.Add_Auto.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Add_Auto.Location = new System.Drawing.Point(12, 773);
            this.Add_Auto.Name = "Add_Auto";
            this.Add_Auto.Size = new System.Drawing.Size(439, 37);
            this.Add_Auto.TabIndex = 22;
            this.Add_Auto.Text = "Добавить авто";
            this.Add_Auto.UseVisualStyleBackColor = true;
            this.Add_Auto.Click += new System.EventHandler(this.Add_Auto_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Delete_button.Location = new System.Drawing.Point(12, 859);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(598, 39);
            this.Delete_button.TabIndex = 21;
            this.Delete_button.Text = "Удалить запись об автомобиле";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Sprav_button
            // 
            this.Sprav_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Sprav_button.Location = new System.Drawing.Point(12, 904);
            this.Sprav_button.Name = "Sprav_button";
            this.Sprav_button.Size = new System.Drawing.Size(598, 37);
            this.Sprav_button.TabIndex = 20;
            this.Sprav_button.Text = "Справка";
            this.Sprav_button.UseVisualStyleBackColor = true;
            this.Sprav_button.Click += new System.EventHandler(this.Sprav_button_Click);
            // 
            // Del_filters
            // 
            this.Del_filters.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Del_filters.Location = new System.Drawing.Point(457, 730);
            this.Del_filters.Name = "Del_filters";
            this.Del_filters.Size = new System.Drawing.Size(153, 123);
            this.Del_filters.TabIndex = 19;
            this.Del_filters.Text = "Cбросить фильтр";
            this.Del_filters.UseVisualStyleBackColor = true;
            this.Del_filters.Click += new System.EventHandler(this.Del_filters_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(616, 904);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(634, 37);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Search.Location = new System.Drawing.Point(12, 730);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(439, 37);
            this.Search.TabIndex = 17;
            this.Search.Text = "Поиск авто по фильтру";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Change_auto
            // 
            this.Change_auto.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Change_auto.Location = new System.Drawing.Point(12, 816);
            this.Change_auto.Name = "Change_auto";
            this.Change_auto.Size = new System.Drawing.Size(439, 37);
            this.Change_auto.TabIndex = 23;
            this.Change_auto.Text = "Редактировать авто";
            this.Change_auto.UseVisualStyleBackColor = true;
            this.Change_auto.Click += new System.EventHandler(this.Change_auto_Click);
            // 
            // Open_Client_table
            // 
            this.Open_Client_table.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Open_Client_table.Location = new System.Drawing.Point(616, 730);
            this.Open_Client_table.Name = "Open_Client_table";
            this.Open_Client_table.Size = new System.Drawing.Size(634, 168);
            this.Open_Client_table.TabIndex = 24;
            this.Open_Client_table.Text = "Посмотреть данные о клиентах";
            this.Open_Client_table.UseVisualStyleBackColor = true;
            this.Open_Client_table.Click += new System.EventHandler(this.Open_Client_table_Click);
            // 
            // Open_Sdel_Table
            // 
            this.Open_Sdel_Table.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Open_Sdel_Table.Location = new System.Drawing.Point(811, 12);
            this.Open_Sdel_Table.Name = "Open_Sdel_Table";
            this.Open_Sdel_Table.Size = new System.Drawing.Size(439, 37);
            this.Open_Sdel_Table.TabIndex = 25;
            this.Open_Sdel_Table.Text = "Открыть таблицу сделок ";
            this.Open_Sdel_Table.UseVisualStyleBackColor = true;
            this.Open_Sdel_Table.Click += new System.EventHandler(this.Open_Sdel_Table_Click);
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Import.Location = new System.Drawing.Point(12, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(779, 37);
            this.Import.TabIndex = 26;
            this.Import.Text = "Выгрузить данные о сделках в Excel";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Tabel_auto_for_admin
            // 
            this.Tabel_auto_for_admin.AllowUserToAddRows = false;
            this.Tabel_auto_for_admin.AllowUserToDeleteRows = false;
            this.Tabel_auto_for_admin.AllowUserToResizeColumns = false;
            this.Tabel_auto_for_admin.AllowUserToResizeRows = false;
            this.Tabel_auto_for_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabel_auto_for_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Tabel_auto_for_admin.Location = new System.Drawing.Point(13, 56);
            this.Tabel_auto_for_admin.Name = "Tabel_auto_for_admin";
            this.Tabel_auto_for_admin.ReadOnly = true;
            this.Tabel_auto_for_admin.RowTemplate.Height = 24;
            this.Tabel_auto_for_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabel_auto_for_admin.Size = new System.Drawing.Size(1237, 668);
            this.Tabel_auto_for_admin.TabIndex = 27;
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
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 953);
            this.ControlBox = false;
            this.Controls.Add(this.Tabel_auto_for_admin);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Open_Sdel_Table);
            this.Controls.Add(this.Open_Client_table);
            this.Controls.Add(this.Change_auto);
            this.Controls.Add(this.Add_Auto);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Sprav_button);
            this.Controls.Add(this.Del_filters);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 1000);
            this.Name = "Admin_Form";
            this.Text = "Окно администратора";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Tabel_auto_for_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Auto;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Sprav_button;
        private System.Windows.Forms.Button Del_filters;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Change_auto;
        private System.Windows.Forms.Button Open_Client_table;
        private System.Windows.Forms.Button Open_Sdel_Table;
        private System.Windows.Forms.Button Import;
        public System.Windows.Forms.DataGridView Tabel_auto_for_admin;
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
    }
}