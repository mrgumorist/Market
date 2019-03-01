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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox6.Text != "")
            {
                var product = new Entitis.Products();
                Entitis.Context context = new Entitis.Context();
                product.Name = textBox1.Text;
                product.Descriprion = textBox2.Text;
                product.WeightOrVolume = textBox3.Text;
                product.SpecialCode = textBox6.Text;
                context.products.Add(product);
                MessageBox.Show("Вдало доданий!");
                context.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Помилка! Одне з полів є пустим! ");
            }
        }
    }
}
