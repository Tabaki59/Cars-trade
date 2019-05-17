namespace Информационная_система_Прокат_автомобилей
{
    partial class Guide_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guide_Form));
            this.Close_guide = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Close_guide
            // 
            this.Close_guide.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Close_guide.Location = new System.Drawing.Point(12, 554);
            this.Close_guide.Name = "Close_guide";
            this.Close_guide.Size = new System.Drawing.Size(660, 47);
            this.Close_guide.TabIndex = 5;
            this.Close_guide.Text = "Закрыть справку";
            this.Close_guide.UseVisualStyleBackColor = true;
            this.Close_guide.Click += new System.EventHandler(this.Close_guide_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(660, 517);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Guide_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 613);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Close_guide);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(700, 660);
            this.MinimumSize = new System.Drawing.Size(700, 660);
            this.Name = "Guide_Form";
            this.Text = "Guide_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_guide;
        private System.Windows.Forms.TextBox textBox1;
    }
}