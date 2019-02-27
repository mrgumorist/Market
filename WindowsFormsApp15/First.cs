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
    }
}
