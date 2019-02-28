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
using System.Windows.Controls;
using WindowsFormsApp15.Entitis;

namespace WindowsFormsApp15
{
    public partial class AdminPanel : Form
    {
        Entitis.Context context = new Entitis.Context();
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
            dataGridView1.DataSource = context.users.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.users.ToList();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var element = ((List<Entitis.User>)dataGridView1.DataSource)[e.RowIndex];
            int id=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            User user = context.users.FirstOrDefault(t => t.ID == id);
            user.Login = element.Login;
            user.Password = element.Password;
            user.Name = element.Name;
            user.Surname = element.Surname;
            user.TypeOfAccount = element.TypeOfAccount;
            user.LastLogin = element.LastLogin;

            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
