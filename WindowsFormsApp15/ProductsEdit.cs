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
    public partial class ProductsEdit : Form
    {
        Entitis.Context context = new Entitis.Context();
        public ProductsEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.products.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Увага! Name - Назва(Наприклад Майонез торчин) " + Environment.NewLine + "Descriprion - Опис, WeightOrVolume - Вага чи Об'єм" + Environment.NewLine + "SpecialCode- спеціальний код");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.products.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            AddProduct add = new AddProduct();
            add.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = ((List<Entitis.Products>)dataGridView1.DataSource)[dataGridView1.CurrentCell.RowIndex].ID;
            var user = ((List<Entitis.Products>)dataGridView1.DataSource)[dataGridView1.CurrentCell.RowIndex];
            DialogResult dialogResult = MessageBox.Show("Ви точно бажаєте видалити?", "Ви точно бажаєте видалити?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                context.products.Remove(user);
                MessageBox.Show("Вдале видалення!");
                context.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = context.products.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Видалення відмінено!");
            }
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var element = ((List<Entitis.Products>)dataGridView1.DataSource)[e.RowIndex];
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Entitis.Products product = context.products.FirstOrDefault(t => t.ID == id);
            product.Descriprion = element.Descriprion;
            product.Name = element.Name;
            product.SpecialCode = element.SpecialCode;
            product.WeightOrVolume = element.WeightOrVolume;

        }
    }
}
