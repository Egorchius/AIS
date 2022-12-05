namespace АИС_Магазин_компьютерных_комплектующих
{
    partial class Enter
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
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Box
            // 
            this.Login_Box.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Box.Location = new System.Drawing.Point(263, 124);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(293, 31);
            this.Login_Box.TabIndex = 0;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(179, 124);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(59, 23);
            this.Login_label.TabIndex = 1;
            this.Login_label.Text = "Логин";
            // 
            // Password_box
            // 
            this.Password_box.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_box.Location = new System.Drawing.Point(263, 174);
            this.Password_box.Name = "Password_box";
            this.Password_box.PasswordChar = '*';
            this.Password_box.Size = new System.Drawing.Size(293, 31);
            this.Password_box.TabIndex = 4;
            this.Password_box.UseSystemPasswordChar = true;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(179, 177);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(70, 23);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(341, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Авторизация";
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_button.Location = new System.Drawing.Point(345, 236);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(111, 47);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Login_Box);
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_Box;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK_button;
    }
}