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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            var temp = context.prodHistory.ToList();
            dataGridView1.DataSource = temp ;
        }
    }
}
