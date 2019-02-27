using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Entitis
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required, ForeignKey("Productt")]
        public int ProductID { get; set; }
        public virtual Products Productt { get; set; }
        public virtual ICollection<ProductsHistory> IProducts { get; set; }
        public int Count { get; set; }
        public int PriceByOne { get; set; }
    }
}
