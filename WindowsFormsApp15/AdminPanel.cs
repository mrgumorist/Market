using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Entitis.Context context = new Entitis.Context();
            dataGridView1.DataSource = context.users.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            MessageBox.Show(context.users.Count().ToString());
        }
    }
}
