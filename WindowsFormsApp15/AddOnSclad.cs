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
    public partial class AddOnSclad : Form
    {
        public int ID;
        public AddOnSclad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для додавання продуктів на склад, натисніть на продукт, натисніть на кнопку обрати продукт та перейдіть у наступний пункт для налаштування !");

        }

        private void AddOnSclad_Load(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            dataGridView1.DataSource = context.products.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            int id = ((List<Entitis.Products>)dataGridView1.DataSource)[dataGridView1.CurrentCell.RowIndex].ID;
            dataGridView1.Enabled = false;
            ID = id;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            button4.Enabled = false;
            ID = -1;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Entitis.Product product = new Entitis.Product();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (ID != -1)
                {
                    product.ProductID = ID;
                    product.Count = int.Parse(textBox1.Text);
                    product.PriceByOne = double.Parse(textBox2.Text);
                    product.MarkUp = int.Parse(textBox3.Text);
                    double temp = product.PriceByOne + (product.PriceByOne / 100 * product.MarkUp);
                    textBox4.Text = temp.ToString();
                    product.LastPrice = temp;
                    Entitis.Context context = new Entitis.Context();
                    context.product.Add(product);
                    context.SaveChanges();
                    MessageBox.Show("Успішно доданий");
                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Error ID");
                }
            }
            else
            {
                MessageBox.Show("Поля не можуть бути пустими");
            }
        }
    }
}
