using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Login : Form
    {
        int num;
        public Login(int num)
        {
            this.num = num;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool finded = false;
            Entitis.Context a = new Entitis.Context();
            foreach (var item in a.users)
            {
                if (item.Login == textBox1.Text && item.Password == textBox2.Text && num == item.TypeOfAccount)
                {
                    MessageBox.Show("Вдалий вхід");
                    finded = true;
                    item.LastLogin = DateTime.Now;
                    break;
                }
            }
            if (finded != true)
            {
                MessageBox.Show("Аккаунт не найдений! Спробуйте знову!");
            }
            else
            {

                Hide();
                if (num == 1)
                {
                    Продавець продавець = new Продавець();
                    продавець.ShowDialog();
                    Close();
                }
                else if (num == 2)
                {
                    ManagerPanel panel = new ManagerPanel();
                    panel.ShowDialog();
                    Close();
                }
                else
                if (num == 3)
                {
                    AdminPanel admin = new AdminPanel();
                    admin.ShowDialog();
                    Close();
                }
            }
        }
    }
}
