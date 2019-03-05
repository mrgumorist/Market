using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Entitis
{
    [Table("ProductsHistory")]
    public class ProductsHistory
    {
        [Key]
        public int ID { get; set; }
        [Required, ForeignKey("Productt")]
        public int ProductID { get; set; }
        public virtual Product Productt { get; set; }
        public DateTime dateTransaction { get; set; }
        public int Type { get; set; } //1-Додано 2-Продано 3-Списано
    }
}
