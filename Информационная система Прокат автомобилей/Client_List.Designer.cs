namespace Информационная_система_Прокат_автомобилей
{
    partial class Client_List
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
            this.Client_lists = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Client_lists)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(12, 609);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(771, 52);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Client_lists
            // 
            this.Client_lists.AllowUserToAddRows = false;
            this.Client_lists.AllowUserToDeleteRows = false;
            this.Client_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Client_lists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Client_lists.Location = new System.Drawing.Point(12, 12);
            this.Client_lists.Name = "Client_lists";
            this.Client_lists.ReadOnly = true;
            this.Client_lists.RowTemplate.Height = 24;
            this.Client_lists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Client_lists.Size = new System.Drawing.Size(771, 590);
            this.Client_lists.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Серия и номер паспорта";
            this.Column1.MinimumWidth = 40;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер телефона";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Client_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 673);
            this.ControlBox = false;
            this.Controls.Add(this.Client_lists);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(829, 720);
            this.MinimumSize = new System.Drawing.Size(829, 720);
            this.Name = "Client_List";
            this.Text = "Client_List";
            ((System.ComponentModel.ISupportInitialize)(this.Client_lists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridView Client_lists;
    }
}