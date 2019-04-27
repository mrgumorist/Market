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
    public partial class AvaliableProducts : Form
    {

        public AvaliableProducts()
        {
            InitializeComponent();
        }

        private void AvaliableProducts_Load(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            var temp = context.product.Select(t => new {
                ID = t.ID,
                НазваПродукту = t.Productt.Name,
                СпеціальнийКод = t.Productt.SpecialCode,
                ВагаЧиОбєм = t.Productt.WeightOrVolume,
                Кількість = t.Count,
                Ціна = t.PriceByOne,
                Націнка = t.MarkUp,
                ЦіназНацінкою = t.LastPrice,


            });
            dataGridView1.DataSource = temp.ToList();
        }
    }
}
