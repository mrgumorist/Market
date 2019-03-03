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
    }
}
