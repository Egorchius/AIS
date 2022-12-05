using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Linq.Enumerable;
using System.Windows.Forms;

namespace АИС_Магазин_компьютерных_комплектующих
{
    public partial class Stats : Form
    {
        public static string log_path = @"log.dat";
        public static List<Магазин.good> good_for_stats = new List<Магазин.good>();
        Dictionary<string, int> goods = new Dictionary<string, int>();
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            good_for_stats.Clear();
            FileReader(log_path);
            int sum = 0;
            for(int i=0;i<good_for_stats.Count;i++)
            {
                Log_listBox.Items.Add(good_for_stats[i].name + " " + good_for_stats[i].price + "Р");
                sum += good_for_stats[i].price;
                if(goods.ContainsKey(good_for_stats[i].name))
                {
                    goods[good_for_stats[i].name]++;
                }
                else
                {
                    goods.Add(good_for_stats[i].name, 1);
                }
            }
            goods=goods.OrderByDescending(pair=>pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            All_price_label.Text = Convert.ToString(sum)+" Р";
            string str = goods.FirstOrDefault(x => x.Value > 0).Key;
            label5.Text = str + " " + goods.FirstOrDefault(x => x.Key == str).Value + " штук";
        }
        static void FileWriter(string path)
        {

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    //foreach (Магазин.good count in good_for_stats)
                    //{
                    //    writer.Write(count.name);
                    //    writer.Write(count.category);
                    //    writer.Write(count.price);
                    //    writer.Write(count.discription);
                    //}
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void AddGood(int price, int category, string name, string discription)
        {
            Магазин.good good = new Магазин.good(price, category, name, discription);
            good_for_stats.Add(good);
        }
        static void FileReader(string path)
        {

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        int category = reader.ReadInt32();
                        int price = reader.ReadInt32();
                        string disription = reader.ReadString();
                        AddGood(price, category, name, disription);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void Log_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex;
            switch(n)
            {
                case 0:
                    for (int i = 0; i < good_for_stats.Count - 1; i++)
                    {
                        for (int j = i + 1; j < good_for_stats.Count; j++)
                        {
                            if (good_for_stats[i].price < good_for_stats[j].price)
                            {
                                Магазин.good temp = good_for_stats[i];
                                good_for_stats[i] = good_for_stats[j];
                                good_for_stats[j] = temp;
                            }
                        }
                    }
                    Log_listBox.Items.Clear();
                    for (int i = 0; i < good_for_stats.Count; i++)
                    {
                        Log_listBox.Items.Add(good_for_stats[i].name + " " + good_for_stats[i].price + "Р");
                    }
                    break;
                case 1:
                    for (int i = 0; i < good_for_stats.Count - 1; i++)
                    {
                        for (int j = i + 1; j < good_for_stats.Count; j++)
                        {
                            if (good_for_stats[i].price > good_for_stats[j].price)
                            {
                                Магазин.good temp = good_for_stats[i];
                                good_for_stats[i] = good_for_stats[j];
                                good_for_stats[j] = temp;
                            }
                        }
                    }
                    Log_listBox.Items.Clear();
                    for (int i = 0; i < good_for_stats.Count; i++)
                    {
                        Log_listBox.Items.Add(good_for_stats[i].name + " " + good_for_stats[i].price + "Р");
                    }
                    break;
                case 2:
                    for (int i = 0; i < good_for_stats.Count - 1; i++)
                    {
                        for (int j = i + 1; j < good_for_stats.Count; j++)
                        {
                            if (good_for_stats[i].category < good_for_stats[j].category)
                            {
                                Магазин.good temp = good_for_stats[i];
                                good_for_stats[i] = good_for_stats[j];
                                good_for_stats[j] = temp;
                            }
                        }
                    }
                    Log_listBox.Items.Clear();
                    for (int i = 0; i < good_for_stats.Count; i++)
                    {
                        Log_listBox.Items.Add(good_for_stats[i].name + " " + good_for_stats[i].price + "Р");
                    }
                    break;
                case 3:
                    for (int i = 0; i < good_for_stats.Count - 1; i++)
                    {
                        for (int j = i + 1; j < good_for_stats.Count; j++)
                        {
                            if (good_for_stats[i].category > good_for_stats[j].category)
                            {
                                Магазин.good temp = good_for_stats[i];
                                good_for_stats[i] = good_for_stats[j];
                                good_for_stats[j] = temp;
                            }
                        }
                    }
                    Log_listBox.Items.Clear();
                    for (int i = 0; i < good_for_stats.Count; i++)
                    {
                        Log_listBox.Items.Add(good_for_stats[i].name + " " + good_for_stats[i].price + "Р");
                    }
                    break;
                default:
                    break;
            }
        }

        private void All_price_label_Click(object sender, EventArgs e)
        {

        }
    }
}
