using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Delete_Products : Form
    {
        public Delete_Products()
        {
            InitializeComponent();
        }

        private void Delete_Products_Load(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            dataGridView1.DataSource= context.product.ToList();
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
