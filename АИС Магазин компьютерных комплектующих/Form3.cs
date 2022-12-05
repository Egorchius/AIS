using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_Магазин_компьютерных_комплектующих
{
    public partial class Add_good_form : Form
    {
        public Add_good_form()
        {
            InitializeComponent();
            Name_textBox.Validating += Name_textBox_TextChanged;

        }       
        private void Add_good_form_Load(object sender, EventArgs e)
        {
            Error_label.Hide();

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
       {
            if (String.IsNullOrEmpty(Name_textBox.Text))
            {
                errorProvider1.SetError(Name_textBox, "Не указано название");
            }            
            else
            {
                errorProvider1.Clear();
            }
        }
       
          private void Categories_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Discription_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Price_textBox.Text);
                errorProvider2.Clear();
            }
            catch(FormatException)
            {
                errorProvider2.SetError(Price_textBox, "Введите число");
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Error_label.Text = "";
            Error_label.Show();
            if (Categories_comboBox.SelectedIndex != -1)
            {
                try
                {
                    string name = Name_textBox.Text;
                    if(String.IsNullOrEmpty(name))
                    {
                        int c = Convert.ToInt32(name);
                    }
                    int price = Convert.ToInt32(Price_textBox.Text);
                    int category = Categories_comboBox.SelectedIndex + 1;
                    string disription = Discription_richTextBox.Text;
                    Магазин.AddGood(price, category, name, disription);
                    Магазин.AddGoodToFile(Магазин.path, price, category, name, disription);
                    Error_label.Text = "Товар успешно записан";
                    Name_textBox.Clear();
                    errorProvider1.Clear();
                    Price_textBox.Clear();
                    errorProvider2.Clear();
                    Discription_richTextBox.Clear();
                }
                catch (FormatException)
                {
                    Error_label.Text = "Ошибка, введите правильно данные";
                }
            }
            else
            {
                Error_label.Text = "Ошибка, выберите категорию";
            }
        }
    }
}
