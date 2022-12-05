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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(Login_Box.Text=="admin"&&Password_box.Text=="admin")
            {
                Магазин.Add_Good_flag = true;               
            }
            else
            {
                Магазин.Add_Good_flag = false;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Enter_Load(object sender, EventArgs e)
        {
           
        }
    }
}
