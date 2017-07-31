namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Output = new System.Windows.Forms.Label();
            this.GetWeapon = new System.Windows.Forms.Button();
            this.GetAttempts = new System.Windows.Forms.Button();
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Output.Location = new System.Drawing.Point(39, 40);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 0;
            // 
            // GetWeapon
            // 
            this.GetWeapon.Location = new System.Drawing.Point(12, 72);
            this.GetWeapon.Name = "GetWeapon";
            this.GetWeapon.Size = new System.Drawing.Size(260, 23);
            this.GetWeapon.TabIndex = 1;
            this.GetWeapon.Text = "Try";
            this.GetWeapon.UseVisualStyleBackColor = true;
            this.GetWeapon.Click += new System.EventHandler(this.GetWeapon_Click);
            // 
            // GetAttempts
            // 
            this.GetAttempts.Location = new System.Drawing.Point(12, 111);
            this.GetAttempts.Name = "GetAttempts";
            this.GetAttempts.Size = new System.Drawing.Size(260, 23);
            this.GetAttempts.TabIndex = 2;
            this.GetAttempts.Text = "Get attempts";
            this.GetAttempts.UseVisualStyleBackColor = true;
            this.GetAttempts.Click += new System.EventHandler(this.GetAttempts_Click);
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.AutoSize = true;
            this.AttemptsLabel.Location = new System.Drawing.Point(259, 22);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(13, 13);
            this.AttemptsLabel.TabIndex = 3;
            this.AttemptsLabel.Text = "5";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.AttemptsLabel);
            this.Controls.Add(this.GetAttempts);
            this.Controls.Add(this.GetWeapon);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button GetWeapon;
        private System.Windows.Forms.Button GetAttempts;
        private System.Windows.Forms.Label AttemptsLabel;
    }
}

