using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox6.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                foreach (var item in )
                {

                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
