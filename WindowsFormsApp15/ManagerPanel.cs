﻿using System;
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
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ProductsEdit edit = new ProductsEdit();
            edit.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddOnSclad addOn = new AddOnSclad();
            Hide();
            addOn.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
