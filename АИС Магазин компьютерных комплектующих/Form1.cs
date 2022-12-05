using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_Магазин_компьютерных_комплектующих
{
    
    public partial class Магазин : Form
    {
        public static string path = @"file.dat";
        public static bool Add_Good_flag = false;
        int index;
        public Магазин()
        {
            
            InitializeComponent();

           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Add_good.Hide();
            Name_label.Hide();
            Price_label.Hide();
            Add_To_Korzina_button.Hide();
            Discription_richTextBox.Hide();
            Add_good.Hide();
            Exit_button.Hide();
            Statistics.Hide();
            Delete_good_button.Hide();
            Admin_label.Hide();
            NametextBox.Hide();
            PricetextBox.Hide();
            Edit_button.Hide();
            //FillList();
            //FileWriter(log_path);
            FileReader(path);           
        }
        public class good
        {
            public string name;
            public int price;
            public int category;
            public string discription;
            public good(int price, int category, string name,string discription)
            {
                this.price = price;
                this.name = name;
                this.category = category;
                this.discription = discription;
            }
        }
        public static List<good> goods = new List<good>();
        static List<good> goods_for_categories = new List<good>();
        public static List<good> goods_in_korzina = new List<good>();      

        public static void AddGood(int price,int category,string name, string discription)
        {
            good good = new good(price, category, name,discription);
            goods.Add(good);
        }
        
        static void FileWriter(string path)
        {
            
           try
            {
                using (BinaryWriter writer=new BinaryWriter(File.Open(path, FileMode.Create)))
                    {
                     foreach(good count in goods)
                     {
                        writer.Write(count.name);
                        writer.Write(count.category);
                        writer.Write(count.price);
                        writer.Write(count.discription);
                    }
                    }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void AddGoodToFile(string path,int price,int category,string name, string discription)
        {

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
                {
                    
                        writer.Write(name);
                        writer.Write(category);
                        writer.Write(price);
                        writer.Write(discription);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void FileReader(string path)
        {

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {                      
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        int category = reader.ReadInt32();
                        int price = reader.ReadInt32();
                        string disription = reader.ReadString();
                        AddGood(price, category, name,disription);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private void Korzina_Click(object sender, EventArgs e)
        {
            using (Korzina NewForm = new Korzina())
            {
                if (NewForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void Categories_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Goods_listBox.Items.Clear();
            goods_for_categories.Clear();
            Name_label.Hide();
            Price_label.Hide();
            Add_To_Korzina_button.Hide();
            Discription_richTextBox.Hide();
            int category = Categories_comboBox.SelectedIndex+1;
            foreach (good count in goods)
            {
                if (category == count.category)
                {
                    Goods_listBox.Items.Add(count.name + " " + count.price + "Р");
                    goods_for_categories.Add(count);
                }
            }

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            using (Enter NewForm = new Enter())
            {
                if (NewForm.ShowDialog() == DialogResult.OK)
                {
                   if(Add_Good_flag)
                    {
                        Enter.Hide();
                        Add_good.Show();
                        Exit_button.Show();
                        Statistics.Show();
                        Delete_good_button.Show();
                        Admin_label.Show();
                        Edit_button.Show();
                    }
                   else
                    {
                        Add_good.Hide();
                    }
                }
            }
        }

        private void Goods_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Name_label.Show();
                index = Goods_listBox.SelectedIndex;
                Name_label.Text = goods_for_categories[index].name;
                Price_label.Show();
                Price_label.Text = Convert.ToString(goods_for_categories[index].price) ;
                Add_To_Korzina_button.Show();
                Discription_richTextBox.Show();
                Discription_richTextBox.Text = goods_for_categories[index].discription;
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }

        private void Add_good_Click(object sender, EventArgs e)
        {
            Add_good_form newForm = new Add_good_form();
            newForm.Show();
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            Stats newForm = new Stats();
            newForm.Show();
        }

        private void Add_To_Korzina_button_Click(object sender, EventArgs e)
        {
            goods_in_korzina.Add(goods_for_categories[index]);
        }

        private void Delete_good_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < goods.Count; i++)
            {
                try
                {
                    if (goods[i].name == goods_for_categories[Goods_listBox.SelectedIndex].name)
                    {
                        goods.RemoveAt(i);
                        FileWriter(path);
                        goods_for_categories.RemoveAt(Goods_listBox.SelectedIndex);
                        Goods_listBox.Items.RemoveAt(Goods_listBox.SelectedIndex);
                        Name_label.Hide();
                        Price_label.Hide();
                        Add_To_Korzina_button.Hide();
                        Discription_richTextBox.Hide();
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                
                }
             }
        }

        private void Sort_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Sort_comboBox.SelectedIndex;
            
            switch (n)
            {
                case 0:
                    for (int i = 0; i < goods_for_categories.Count - 1; i++)
                    {
                        for (int j = i + 1; j < goods_for_categories.Count; j++)
                        {
                            if (goods_for_categories[i].price < goods_for_categories[j].price)
                            {
                                good temp = goods_for_categories[i];
                                goods_for_categories[i] = goods_for_categories[j];
                                goods_for_categories[j] = temp;
                            }
                        }
                    }
                    Goods_listBox.Items.Clear();
                    int category = Categories_comboBox.SelectedIndex + 1;
                    for (int i=0; i < goods_for_categories.Count ; i++)
                    {
                        if (category == goods_for_categories[i].category)
                        {
                            Goods_listBox.Items.Add(goods_for_categories[i].name + " " + goods_for_categories[i].price + "Р");
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < goods_for_categories.Count - 1; i++)
                    {
                        for (int j = i + 1; j < goods_for_categories.Count; j++)
                        {
                            if (goods_for_categories[i].price > goods_for_categories[j].price)
                            {
                                good temp = goods_for_categories[i];
                                goods_for_categories[i] = goods_for_categories[j];
                                goods_for_categories[j] = temp;
                            }
                        }
                    }
                    Goods_listBox.Items.Clear();
                    category = Categories_comboBox.SelectedIndex + 1;
                    for (int i = 0; i < goods_for_categories.Count; i++)
                    {
                        if (category == goods_for_categories[i].category)
                        {
                            Goods_listBox.Items.Add(goods_for_categories[i].name + " " + goods_for_categories[i].price + "Р");
                        }
                    }
                    break;
                default:
                    break;
                    
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {                    
            Add_good.Hide();
            Exit_button.Hide();
            Statistics.Hide();
            Delete_good_button.Hide();
            Add_Good_flag = false;
            Enter.Show();
            Admin_label.Hide();
            Edit_button.Hide();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (Goods_listBox.SelectedIndex != -1)
            {
                if (Discription_richTextBox.ReadOnly == false)
                {
                    for (int i = 0; i < goods.Count; i++)
                    {
                        if (goods[i].name == Name_label.Text)
                        {
                            goods[i].name = NametextBox.Text;
                            goods[i].price = Convert.ToInt32(PricetextBox.Text);
                            goods[i].discription = Discription_richTextBox.Text;
                        }
                    }
                    FileWriter(path);
                    Name_label.Text = NametextBox.Text;
                    goods_for_categories[index].name = NametextBox.Text;
                    goods_for_categories[index].price = Convert.ToInt32(PricetextBox.Text);
                    goods_for_categories[index].discription = Discription_richTextBox.Text;
                    Goods_listBox.Items.Clear();
                    foreach (good good in goods_for_categories)
                    {
                        Goods_listBox.Items.Add(good.name + " " + good.price + "Р");
                    }
                    Price_label.Text = PricetextBox.Text;
                    NametextBox.Hide();
                    PricetextBox.Hide();
                    Discription_richTextBox.ReadOnly = true;
                    Sort_comboBox.Show();
                    Sort_label.Show();
                    Goods_listBox.SelectedIndex = index;
                }
                else
                {
                    Discription_richTextBox.ReadOnly = false;
                    NametextBox.Text = Name_label.Text;
                    NametextBox.Show();
                    PricetextBox.Text = Price_label.Text;
                    PricetextBox.Show();
                    Sort_comboBox.Hide();
                    Sort_label.Hide();
                }
            }
        }

        private void Discription_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PricetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(PricetextBox.Text);
                errorProvider1.Clear();
                if(errorProvider2.GetError(NametextBox) =="")
                {
                    Edit_button.Show();
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(PricetextBox, "Введите число");
                Edit_button.Hide();
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NametextBox.Text))
            {
                errorProvider2.SetError(NametextBox, "Не указано название");
                Edit_button.Hide();
            }
            else
            {
                errorProvider2.Clear();
                if(errorProvider1.GetError(PricetextBox)=="")
                {
                    Edit_button.Show();
                }
            }
        }
    }
}
