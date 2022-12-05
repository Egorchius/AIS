namespace АИС_Магазин_компьютерных_комплектующих
{
    partial class Магазин
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
            this.components = new System.ComponentModel.Container();
            this.Statistics = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Korzina = new System.Windows.Forms.Button();
            this.Categories_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Goods_listBox = new System.Windows.Forms.ListBox();
            this.Add_good = new System.Windows.Forms.Button();
            this.Discription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Add_To_Korzina_button = new System.Windows.Forms.Button();
            this.Price_label = new System.Windows.Forms.Label();
            this.Delete_good_button = new System.Windows.Forms.Button();
            this.Sort_comboBox = new System.Windows.Forms.ComboBox();
            this.Sort_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Admin_label = new System.Windows.Forms.Label();
            this.Edit_button = new System.Windows.Forms.Button();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Statistics
            // 
            this.Statistics.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistics.Location = new System.Drawing.Point(209, 12);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(176, 34);
            this.Statistics.TabIndex = 0;
            this.Statistics.Text = "Статистика";
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(778, 12);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(176, 34);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Вход";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Korzina
            // 
            this.Korzina.BackColor = System.Drawing.Color.Transparent;
            this.Korzina.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Korzina.Location = new System.Drawing.Point(12, 12);
            this.Korzina.Name = "Korzina";
            this.Korzina.Size = new System.Drawing.Size(191, 34);
            this.Korzina.TabIndex = 2;
            this.Korzina.Text = "Корзина";
            this.Korzina.UseVisualStyleBackColor = false;
            this.Korzina.Click += new System.EventHandler(this.Korzina_Click);
            // 
            // Categories_comboBox
            // 
            this.Categories_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.Categories_comboBox.Location = new System.Drawing.Point(12, 131);
            this.Categories_comboBox.Name = "Categories_comboBox";
            this.Categories_comboBox.Size = new System.Drawing.Size(208, 21);
            this.Categories_comboBox.TabIndex = 3;
            this.Categories_comboBox.SelectedIndexChanged += new System.EventHandler(this.Categories_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категории";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Goods_listBox
            // 
            this.Goods_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Goods_listBox.FormattingEnabled = true;
            this.Goods_listBox.ItemHeight = 15;
            this.Goods_listBox.Location = new System.Drawing.Point(12, 183);
            this.Goods_listBox.Name = "Goods_listBox";
            this.Goods_listBox.Size = new System.Drawing.Size(418, 364);
            this.Goods_listBox.TabIndex = 5;
            this.Goods_listBox.SelectedIndexChanged += new System.EventHandler(this.Goods_listBox_SelectedIndexChanged);
            // 
            // Add_good
            // 
            this.Add_good.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_good.Location = new System.Drawing.Point(391, 12);
            this.Add_good.Name = "Add_good";
            this.Add_good.Size = new System.Drawing.Size(176, 34);
            this.Add_good.TabIndex = 6;
            this.Add_good.Text = "Добавить товар";
            this.Add_good.UseVisualStyleBackColor = true;
            this.Add_good.Click += new System.EventHandler(this.Add_good_Click);
            // 
            // Discription_richTextBox
            // 
            this.Discription_richTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discription_richTextBox.Location = new System.Drawing.Point(469, 183);
            this.Discription_richTextBox.Name = "Discription_richTextBox";
            this.Discription_richTextBox.ReadOnly = true;
            this.Discription_richTextBox.Size = new System.Drawing.Size(474, 226);
            this.Discription_richTextBox.TabIndex = 8;
            this.Discription_richTextBox.Text = "";
            this.Discription_richTextBox.TextChanged += new System.EventHandler(this.Discription_richTextBox_TextChanged);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(466, 164);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(61, 15);
            this.Name_label.TabIndex = 9;
            this.Name_label.Text = "Название";
            // 
            // Add_To_Korzina_button
            // 
            this.Add_To_Korzina_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_To_Korzina_button.Location = new System.Drawing.Point(767, 446);
            this.Add_To_Korzina_button.Name = "Add_To_Korzina_button";
            this.Add_To_Korzina_button.Size = new System.Drawing.Size(176, 34);
            this.Add_To_Korzina_button.TabIndex = 10;
            this.Add_To_Korzina_button.Text = "Добавить в корзину";
            this.Add_To_Korzina_button.UseVisualStyleBackColor = true;
            this.Add_To_Korzina_button.Click += new System.EventHandler(this.Add_To_Korzina_button_Click);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_label.Location = new System.Drawing.Point(465, 449);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(50, 23);
            this.Price_label.TabIndex = 11;
            this.Price_label.Text = "Цена";
            // 
            // Delete_good_button
            // 
            this.Delete_good_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_good_button.Location = new System.Drawing.Point(469, 510);
            this.Delete_good_button.Name = "Delete_good_button";
            this.Delete_good_button.Size = new System.Drawing.Size(210, 30);
            this.Delete_good_button.TabIndex = 12;
            this.Delete_good_button.Text = "Удалить товар";
            this.Delete_good_button.UseVisualStyleBackColor = true;
            this.Delete_good_button.Click += new System.EventHandler(this.Delete_good_button_Click);
            // 
            // Sort_comboBox
            // 
            this.Sort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sort_comboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_comboBox.FormattingEnabled = true;
            this.Sort_comboBox.Items.AddRange(new object[] {
            "По цене по убыванию",
            "По цене по возрастанию"});
            this.Sort_comboBox.Location = new System.Drawing.Point(226, 131);
            this.Sort_comboBox.Name = "Sort_comboBox";
            this.Sort_comboBox.Size = new System.Drawing.Size(204, 23);
            this.Sort_comboBox.TabIndex = 13;
            this.Sort_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sort_comboBox_SelectedIndexChanged);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_label.Location = new System.Drawing.Point(226, 113);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(73, 15);
            this.Sort_label.TabIndex = 14;
            this.Sort_label.Text = "Сортировка\r\n";
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(778, 12);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(176, 34);
            this.Exit_button.TabIndex = 15;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Admin_label
            // 
            this.Admin_label.AutoSize = true;
            this.Admin_label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_label.Location = new System.Drawing.Point(640, 22);
            this.Admin_label.Name = "Admin_label";
            this.Admin_label.Size = new System.Drawing.Size(132, 15);
            this.Admin_label.TabIndex = 16;
            this.Admin_label.Text = "Уровень доступ:admin";
            // 
            // Edit_button
            // 
            this.Edit_button.BackgroundImage = global::АИС_Магазин_компьютерных_комплектующих.Properties.Resources.Без_названия;
            this.Edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit_button.Location = new System.Drawing.Point(436, 183);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(27, 28);
            this.Edit_button.TabIndex = 17;
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // PricetextBox
            // 
            this.PricetextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PricetextBox.Location = new System.Drawing.Point(469, 441);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(86, 31);
            this.PricetextBox.TabIndex = 18;
            this.PricetextBox.TextChanged += new System.EventHandler(this.PricetextBox_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NametextBox.Location = new System.Drawing.Point(469, 161);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(474, 23);
            this.NametextBox.TabIndex = 19;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
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
            // Магазин
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(976, 566);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Admin_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.Sort_comboBox);
            this.Controls.Add(this.Delete_good_button);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Add_To_Korzina_button);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Discription_richTextBox);
            this.Controls.Add(this.Add_good);
            this.Controls.Add(this.Goods_listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Categories_comboBox);
            this.Controls.Add(this.Korzina);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Statistics);
            this.Name = "Магазин";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин компьютерных комплектующих";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Korzina;
        private System.Windows.Forms.ComboBox Categories_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Goods_listBox;
        private System.Windows.Forms.Button Add_good;
        private System.Windows.Forms.RichTextBox Discription_richTextBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Button Add_To_Korzina_button;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Button Delete_good_button;
        private System.Windows.Forms.ComboBox Sort_comboBox;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label Admin_label;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

