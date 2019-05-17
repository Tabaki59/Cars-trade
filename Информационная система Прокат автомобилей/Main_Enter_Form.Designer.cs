namespace Информационная_система_Прокат_автомобилей
{
    partial class Enter_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Client_Enter = new System.Windows.Forms.Button();
            this.Sot_Enter = new System.Windows.Forms.Button();
            this.Admin_enter = new System.Windows.Forms.Button();
            this.Guide = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Client_Enter
            // 
            this.Client_Enter.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Client_Enter.Location = new System.Drawing.Point(13, 13);
            this.Client_Enter.Name = "Client_Enter";
            this.Client_Enter.Size = new System.Drawing.Size(547, 114);
            this.Client_Enter.TabIndex = 0;
            this.Client_Enter.Text = "Войти как клиент";
            this.Client_Enter.UseVisualStyleBackColor = true;
            this.Client_Enter.Click += new System.EventHandler(this.Client_Enter_Click);
            // 
            // Sot_Enter
            // 
            this.Sot_Enter.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Sot_Enter.Location = new System.Drawing.Point(13, 133);
            this.Sot_Enter.Name = "Sot_Enter";
            this.Sot_Enter.Size = new System.Drawing.Size(547, 114);
            this.Sot_Enter.TabIndex = 1;
            this.Sot_Enter.Text = "Войти как сотрудник";
            this.Sot_Enter.UseVisualStyleBackColor = true;
            this.Sot_Enter.Click += new System.EventHandler(this.Sot_Enter_Click);
            // 
            // Admin_enter
            // 
            this.Admin_enter.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_enter.Location = new System.Drawing.Point(13, 253);
            this.Admin_enter.Name = "Admin_enter";
            this.Admin_enter.Size = new System.Drawing.Size(547, 114);
            this.Admin_enter.TabIndex = 2;
            this.Admin_enter.Text = "Войти как администратор";
            this.Admin_enter.UseVisualStyleBackColor = true;
            this.Admin_enter.Click += new System.EventHandler(this.Admin_enter_Click);
            // 
            // Guide
            // 
            this.Guide.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Guide.Location = new System.Drawing.Point(12, 427);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(266, 114);
            this.Guide.TabIndex = 3;
            this.Guide.Text = "Справка";
            this.Guide.UseVisualStyleBackColor = true;
            this.Guide.Click += new System.EventHandler(this.Guide_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Exit.Location = new System.Drawing.Point(294, 427);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(266, 114);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 553);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.Admin_enter);
            this.Controls.Add(this.Sot_Enter);
            this.Controls.Add(this.Client_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(590, 600);
            this.MinimumSize = new System.Drawing.Size(590, 600);
            this.Name = "Enter_Form";
            this.Text = "Вход  в программу ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Client_Enter;
        private System.Windows.Forms.Button Sot_Enter;
        private System.Windows.Forms.Button Admin_enter;
        private System.Windows.Forms.Button Guide;
        private System.Windows.Forms.Button Exit;
    }
}

