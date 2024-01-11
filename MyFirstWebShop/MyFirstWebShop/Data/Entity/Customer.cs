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
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }


        public DateTime Birthday { get; set; }

        public int GernderID { get; set; }

        public int PaymentConditionID { get; set; }


        [Column(TypeName = "decimal(5,4)")]
        public decimal Discount {  get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Gender Gender { get; set; }

    }
}
