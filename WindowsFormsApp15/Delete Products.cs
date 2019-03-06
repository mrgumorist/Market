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
    public partial class Видалити : Form
    {
        public Видалити()
        {
            InitializeComponent();
        }

        private void Delete_Products_Load(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            var temp = context.product.Select(t => new {
                ID = t.ID,
                НазваПродукту = t.Productt.Name,
                СпеціальнийКод=t.Productt.SpecialCode,
                ВагаЧиОбєм = t.Productt.WeightOrVolume,
                Кількість = t.Count,
                Ціна = t.PriceByOne,
                Націнка = t.MarkUp,
                ЦіназНацінкою = t.LastPrice,
                

              });
            dataGridView1.DataSource = temp.ToList();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmpText = textBox1.Text;
            dataGridView1.DataSource = null;
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


            }).Where(t =>t.НазваПродукту.StartsWith(tmpText));
            dataGridView1.DataSource = temp.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmpText = textBox2.Text;
            dataGridView1.DataSource = null;
            Entitis.Context context = new Entitis.Context();
            var temp = context.product.Select(t => new {
                ID=t.ID,
                НазваПродукту = t.Productt.Name,
                СпеціальнийКод = t.Productt.SpecialCode,
                ВагаЧиОбєм = t.Productt.WeightOrVolume,
                Кількість = t.Count,
                Ціна = t.PriceByOne,
                Націнка = t.MarkUp,
                ЦіназНацінкою = t.LastPrice,


            }).Where(t => t.СпеціальнийКод==tmpText);
            dataGridView1.DataSource = temp.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entitis.Context context = new Entitis.Context();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                int Count = int.Parse(selectedRow.Cells[4].Value.ToString());
                
                    int count = int.Parse(textBox3.Text);
                    if(count>0)
                    {
                        if(Count>count)
                        {
                            foreach (var item in context.product)
                            {
                                if(item.ID==id)
                                {
                                    item.Count -= count;
                                    MessageBox.Show("Готово");
                                    Entitis.ProductsHistory history = new Entitis.ProductsHistory();
                                    history.dateTransaction = DateTime.Now;
                                    history.ProductID = id;
                                    history.Type = 3;
                                    context.prodHistory.Add(history);
                                  
                                    break;
                                }
                            }
                        }
                        else if(count==Count)
                        {
                            foreach (var item in context.product)
                            {
                                if (item.ID == id)
                                {
                                    item.Count -= count;
                                    MessageBox.Show("Готово");
                                    Entitis.ProductsHistory history = new Entitis.ProductsHistory();
                                    history.dateTransaction = DateTime.Now;
                                    history.ProductID = id;
                                    history.Type = 3;
                                    context.prodHistory.Add(history);
                                    context.product.Remove(item);
                                   
                                    break;
                                }
                                
                                
                            }
                        }
                        else
                         {
                        MessageBox.Show("Помилка", "ErrorProvider");
                        textBox3.Text = "";
                         }
                    context.SaveChanges();
                    }
                   
              
                Delete_Products_Load(sender, e);
            }

            //int id = ((List<Entitis.Product>)dataGridView1.DataSource)[dataGridView1.CurrentCell.RowIndex].ID;
            //var prod = ((List<Entitis.Product>)dataGridView1.DataSource)[dataGridView1.CurrentCell.RowIndex];
            //DialogResult dialogResult = MessageBox.Show("Ви точно бажаєте видалити?", "Ви точно бажаєте видалити?", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    context.product.Remove(prod);
            //    MessageBox.Show("Вдале видалення!");
            //    var tmp = new Entitis.ProductsHistory();
            //    tmp.dateTransaction = DateTime.Now;
            //    tmp.Type = 3;
            //    tmp.Productt = prod;
            //    context.SaveChanges();
            //    dataGridView1.DataSource = null;
            //    dataGridView1.DataSource = context.product.ToList();

            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("Видалення відмінено!");
            //}
        }
    }
}
