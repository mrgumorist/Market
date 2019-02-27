using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Entitis
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Descriprion { get; set; }
        public string WeightOrVolume { get; set; }
        public string SpecialCode { get; set; }
        public virtual ICollection<Product> IProducts { get; set; }
    }
}
