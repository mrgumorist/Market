using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Entitis;

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
                
                if(textBox2.Text== textBox5.Text)
                {
                    var user = new Entitis.User();
                    user.LastLogin = DateTime.Now;
                    user.Login = textBox1.Text;
                    user.Password = textBox2.Text;
                    user.Name = textBox3.Text;
                    user.Surname = textBox6.Text;
                    if(comboBox1.Text=="Адмін")
                    {
                        user.TypeOfAccount = 3;
                    }
                    else if(comboBox1.Text=="Менеджер")
                    {
                        user.TypeOfAccount = 2;
                    }
                    else 
                    {
                        user.TypeOfAccount = 1;
                    }
                    Entitis.Context context = new Context();
                    context.users.Add(user);
                    MessageBox.Show("Аккаунт доданий");
                    context.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Паролі не співпадають");
                }
            }
            else
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
