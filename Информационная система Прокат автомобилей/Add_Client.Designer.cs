namespace Информационная_система_Прокат_автомобилей
{
    partial class Add_Client_For_Trades
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
            this.FIO = new System.Windows.Forms.TextBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pasport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(12, 441);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(628, 34);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FIO
            // 
            this.FIO.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FIO.Location = new System.Drawing.Point(12, 59);
            this.FIO.MaxLength = 120;
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(628, 34);
            this.FIO.TabIndex = 9;
            this.FIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // Enter_button
            // 
            this.Enter_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Enter_button.Location = new System.Drawing.Point(12, 401);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(628, 34);
            this.Enter_button.TabIndex = 10;
            this.Enter_button.Text = "Ввести данные";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фамилия имя отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Серия и номер паспорта (10 цифр)";
            // 
            // Pasport
            // 
            this.Pasport.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Pasport.Location = new System.Drawing.Point(12, 160);
            this.Pasport.MaxLength = 10;
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(628, 34);
            this.Pasport.TabIndex = 13;
            this.Pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(13, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Номер телефона (11 цифр)";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Phone.Location = new System.Drawing.Point(12, 272);
            this.Phone.MaxLength = 11;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(628, 34);
            this.Phone.TabIndex = 15;
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(7, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Срок аренды авто";
            // 
            // Days
            // 
            this.Days.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Days.Location = new System.Drawing.Point(261, 349);
            this.Days.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Days.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(120, 34);
            this.Days.TabIndex = 17;
            this.Days.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Add_Client_For_Trades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 525);
            this.ControlBox = false;
            this.Controls.Add(this.Days);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Client_For_Trades";
            this.Text = "Add_Client";
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Enter_button;
        public System.Windows.Forms.TextBox FIO;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Pasport;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Phone;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown Days;
    }
}