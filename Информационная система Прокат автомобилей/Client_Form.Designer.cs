namespace Информационная_система_Прокат_автомобилей
{
    partial class Client_Form
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
            this.Search = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Del_filters = new System.Windows.Forms.Button();
            this.Sprav_button = new System.Windows.Forms.Button();
            this.Zabron = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Tabel_auto_for_others)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Search.Location = new System.Drawing.Point(12, 489);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(1238, 52);
            this.Search.TabIndex = 4;
            this.Search.Text = "Поиск по фильтру";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(12, 609);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(1238, 52);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Del_filters
            // 
            this.Del_filters.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Del_filters.Location = new System.Drawing.Point(449, 551);
            this.Del_filters.Name = "Del_filters";
            this.Del_filters.Size = new System.Drawing.Size(370, 52);
            this.Del_filters.TabIndex = 8;
            this.Del_filters.Text = "Cбросить фильтр";
            this.Del_filters.UseVisualStyleBackColor = true;
            this.Del_filters.Click += new System.EventHandler(this.Del_filters_Click);
            // 
            // Sprav_button
            // 
            this.Sprav_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Sprav_button.Location = new System.Drawing.Point(880, 551);
            this.Sprav_button.Name = "Sprav_button";
            this.Sprav_button.Size = new System.Drawing.Size(370, 52);
            this.Sprav_button.TabIndex = 9;
            this.Sprav_button.Text = "Справка";
            this.Sprav_button.UseVisualStyleBackColor = true;
            this.Sprav_button.Click += new System.EventHandler(this.Sprav_button_Click);
            // 
            // Zabron
            // 
            this.Zabron.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Zabron.Location = new System.Drawing.Point(12, 551);
            this.Zabron.Name = "Zabron";
            this.Zabron.Size = new System.Drawing.Size(370, 52);
            this.Zabron.TabIndex = 10;
            this.Zabron.Text = "Забронировать";
            this.Zabron.UseVisualStyleBackColor = true;
            this.Zabron.Click += new System.EventHandler(this.Zabron_Click);
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
            this.Tabel_auto_for_others.Location = new System.Drawing.Point(12, 12);
            this.Tabel_auto_for_others.Name = "Tabel_auto_for_others";
            this.Tabel_auto_for_others.ReadOnly = true;
            this.Tabel_auto_for_others.RowTemplate.Height = 24;
            this.Tabel_auto_for_others.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabel_auto_for_others.Size = new System.Drawing.Size(1238, 471);
            this.Tabel_auto_for_others.TabIndex = 28;
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
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.Tabel_auto_for_others);
            this.Controls.Add(this.Zabron);
            this.Controls.Add(this.Sprav_button);
            this.Controls.Add(this.Del_filters);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Client_Form";
            this.Text = "Окно клиента";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Tabel_auto_for_others)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Del_filters;
        private System.Windows.Forms.Button Sprav_button;
        private System.Windows.Forms.Button Zabron;
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
    }
}