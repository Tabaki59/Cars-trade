namespace Информационная_система_Прокат_автомобилей
{
    partial class Password_form
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
            this.Otmena = new System.Windows.Forms.Button();
            this.Enter_button = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Otmena
            // 
            this.Otmena.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Otmena.Location = new System.Drawing.Point(359, 51);
            this.Otmena.Name = "Otmena";
            this.Otmena.Size = new System.Drawing.Size(134, 43);
            this.Otmena.TabIndex = 8;
            this.Otmena.Text = "Отмена";
            this.Otmena.UseVisualStyleBackColor = true;
            this.Otmena.Click += new System.EventHandler(this.Otmena_Click);
            // 
            // Enter_button
            // 
            this.Enter_button.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Enter_button.Location = new System.Drawing.Point(12, 51);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(341, 43);
            this.Enter_button.TabIndex = 7;
            this.Enter_button.Text = "Войти в программу";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Password.Location = new System.Drawing.Point(12, 11);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(481, 34);
            this.Password.TabIndex = 9;
            // 
            // Password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 106);
            this.ControlBox = false;
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Otmena);
            this.Controls.Add(this.Enter_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(523, 153);
            this.MinimumSize = new System.Drawing.Size(523, 153);
            this.Name = "Password_form";
            this.Text = "Авторизация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Otmena;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.TextBox Password;
    }
}