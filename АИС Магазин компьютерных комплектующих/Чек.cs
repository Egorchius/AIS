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
    public partial class Чек : Form
    {
        Dictionary<string, int> goods = new Dictionary<string, int>();
        public Чек()
        {
            InitializeComponent();
        }

        private void Чек_Load(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i=0;i< Магазин.goods_in_korzina.Count;i++)
            {
                if (goods.ContainsKey(Магазин.goods_in_korzina[i].name))
                {
                    goods[Магазин.goods_in_korzina[i].name]++;
                }
                else
                {
                    goods.Add(Магазин.goods_in_korzina[i].name, 1);
                }
            }
            foreach (var item in goods)
            {
                for (int i = 0; i < Магазин.goods.Count; i++)
                {
                    if(Магазин.goods[i].name==item.Key)
                    richTextBox1.Text += item.Key + " X" + item.Value +" = "+ Магазин.goods[i].price*item.Value+" Р\n";
                }
            }
            for (int i = 0; i < Магазин.goods_in_korzina.Count; i++)
            {
                sum += Магазин.goods_in_korzina[i].price;
            }
            Sum_label.Text = Convert.ToString(sum);
            Магазин.goods_in_korzina.Clear();
        }
    }
}
