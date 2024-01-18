using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class Customer : CreatedModified
    {

        [Key]
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        public DateOnly Birthday { get; set; }

        public int GenderID { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Gender Gender { get; set; }

        public int PaymentConditionID { get; set; }

        [Column(TypeName = "decimal(5,4)"), 
         Range(0, 1)]
        public decimal Discount {  get; set; }

        

    }
}
