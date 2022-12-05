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
    public partial class Korzina : Form
    {
        int total = 0;
        int select_index;
        public Korzina()
        {
            InitializeComponent();
            Delete_button.Hide();
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            
            foreach(Магазин.good count in Магазин.goods_in_korzina)
            {
                Korzina_listBox.Items.Add(count.name + " " + count.price + "Р");
                total += count.price;
            }
            Price_label.Text = Convert.ToString(total)+"Р";
        }

        private void Korzina_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Korzina_listBox.SelectedIndex!=-1)
            Delete_button.Show();
            else
            Delete_button.Hide();
            select_index = Korzina_listBox.SelectedIndex;
        }

        private void Price_label_Click(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Korzina_listBox.Items.Clear();
            Магазин.goods_in_korzina.Clear();
            Price_label.Text = "0 Р";
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
                       
            total -= Магазин.goods_in_korzina[select_index].price;
            Магазин.goods_in_korzina.RemoveAt(select_index);
            Price_label.Text = Convert.ToString(total) + "Р";
            Korzina_listBox.Items.RemoveAt(select_index);
        }

        private void Pay_button_Click(object sender, EventArgs e)
        {
            foreach(Магазин.good good in Магазин.goods_in_korzina)
            {
                
                Магазин.AddGoodToFile(Stats.log_path, good.price, good.category, good.name, good.discription);
            }
            Чек newForm = new Чек();
            newForm.Show();
            Korzina_listBox.Items.Clear();            
            Price_label.Text = "0 Р";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
