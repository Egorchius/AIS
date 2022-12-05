namespace АИС_Магазин_компьютерных_комплектующих
{
    partial class Korzina
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
            this.Korzina_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Pay_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Korzina_listBox
            // 
            this.Korzina_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Korzina_listBox.FormattingEnabled = true;
            this.Korzina_listBox.ItemHeight = 15;
            this.Korzina_listBox.Location = new System.Drawing.Point(12, 63);
            this.Korzina_listBox.Name = "Korzina_listBox";
            this.Korzina_listBox.Size = new System.Drawing.Size(482, 214);
            this.Korzina_listBox.TabIndex = 0;
            this.Korzina_listBox.SelectedIndexChanged += new System.EventHandler(this.Korzina_listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итого:";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_label.Location = new System.Drawing.Point(337, 337);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(124, 23);
            this.Price_label.TabIndex = 2;
            this.Price_label.Text = "1000000000 Р";
            this.Price_label.Click += new System.EventHandler(this.Price_label_Click);
            // 
            // Pay_button
            // 
            this.Pay_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pay_button.Location = new System.Drawing.Point(500, 323);
            this.Pay_button.Name = "Pay_button";
            this.Pay_button.Size = new System.Drawing.Size(182, 52);
            this.Pay_button.TabIndex = 3;
            this.Pay_button.Text = "Оплатить";
            this.Pay_button.UseVisualStyleBackColor = true;
            this.Pay_button.Click += new System.EventHandler(this.Pay_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список товаров";
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Clear_button.Location = new System.Drawing.Point(500, 63);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(182, 44);
            this.Clear_button.TabIndex = 5;
            this.Clear_button.Text = "Очистить корзину";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(500, 113);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(182, 44);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Korzina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pay_button);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Korzina_listBox);
            this.Name = "Korzina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korzina";
            this.Load += new System.EventHandler(this.Korzina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Korzina_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Button Pay_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Delete_button;
    }
}