namespace АИС_Магазин_компьютерных_комплектующих
{
    partial class Add_good_form
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
            this.components = new System.ComponentModel.Container();
            this.Categories_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Discription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Disciption_label = new System.Windows.Forms.Label();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Categories_comboBox
            // 
            this.Categories_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categories_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Categories_comboBox.FormattingEnabled = true;
            this.Categories_comboBox.Items.AddRange(new object[] {
            "Процессоры",
            "Видеокарты",
            "Материнские платы",
            "Оперативная память",
            "Корпуса",
            "Блоки питания",
            "SSD накопители",
            "Жесткие диски",
            "Мониторы",
            "Клавиатуры",
            "Мыши"});
            this.Categories_comboBox.Location = new System.Drawing.Point(542, 73);
            this.Categories_comboBox.Name = "Categories_comboBox";
            this.Categories_comboBox.Size = new System.Drawing.Size(228, 23);
            this.Categories_comboBox.TabIndex = 4;
            this.Categories_comboBox.SelectedIndexChanged += new System.EventHandler(this.Categories_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(598, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите категорию";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(178, 55);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(61, 15);
            this.name_label.TabIndex = 6;
            this.name_label.Text = "Название";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(12, 73);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(398, 23);
            this.Name_textBox.TabIndex = 7;
            this.Name_textBox.TextChanged += new System.EventHandler(this.Name_textBox_TextChanged);
            // 
            // Discription_richTextBox
            // 
            this.Discription_richTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discription_richTextBox.Location = new System.Drawing.Point(12, 155);
            this.Discription_richTextBox.Name = "Discription_richTextBox";
            this.Discription_richTextBox.Size = new System.Drawing.Size(398, 129);
            this.Discription_richTextBox.TabIndex = 8;
            this.Discription_richTextBox.Text = "";
            this.Discription_richTextBox.TextChanged += new System.EventHandler(this.Discription_richTextBox_TextChanged);
            // 
            // Disciption_label
            // 
            this.Disciption_label.AutoSize = true;
            this.Disciption_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disciption_label.Location = new System.Drawing.Point(178, 137);
            this.Disciption_label.Name = "Disciption_label";
            this.Disciption_label.Size = new System.Drawing.Size(63, 15);
            this.Disciption_label.TabIndex = 9;
            this.Disciption_label.Text = "Описание";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_textBox.Location = new System.Drawing.Point(561, 155);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(175, 23);
            this.Price_textBox.TabIndex = 10;
            this.Price_textBox.TextChanged += new System.EventHandler(this.Price_textBox_TextChanged);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_label.Location = new System.Drawing.Point(629, 137);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(35, 15);
            this.Price_label.TabIndex = 11;
            this.Price_label.Text = "Цена";
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_button.Location = new System.Drawing.Point(343, 380);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(125, 58);
            this.OK_button.TabIndex = 12;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_label.Location = new System.Drawing.Point(474, 397);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(79, 24);
            this.Error_label.TabIndex = 13;
            this.Error_label.Text = "Ошибка";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // Add_good_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Disciption_label);
            this.Controls.Add(this.Discription_richTextBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Categories_comboBox);
            this.Name = "Add_good_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.Add_good_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Categories_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.RichTextBox Discription_richTextBox;
        private System.Windows.Forms.Label Disciption_label;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}