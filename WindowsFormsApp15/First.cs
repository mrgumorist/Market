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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Допомога" + Environment.NewLine + "Для входу як продавець тисніть Розпочати сесію" + Environment.NewLine + "Для входу як менеджер тисніть Керувати продуктами" + Environment.NewLine + "Для входу в адмін панель тисніть третю кнопку");

        }

        private void First_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login(1);
            login.ShowDialog();
            Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login(2);
            login.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login(3);
            login.ShowDialog();
            Show();
        }
    }
}
