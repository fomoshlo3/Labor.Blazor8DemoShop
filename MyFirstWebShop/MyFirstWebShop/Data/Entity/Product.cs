using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Column(TypeName= "decimal(5,4)")] //faktorschreibweise für leichteres Rechnen
        [Range(0, 1)]
        public decimal Discount { get; set; } = decimal.Zero;

        [Column(TypeName= "decimal(12,4)")]
        [Range(0, int.MaxValue)]
        public decimal Price {  get; set; } = decimal.Zero;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
