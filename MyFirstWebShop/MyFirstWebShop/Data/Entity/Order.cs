using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class Order : CreatedModified
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(5,4)"), Range(0, 1)]
        public decimal CustomerDiscount { get; set; }

        //ForeignKeys
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderPosition> Positions { get; set; } = new List<OrderPosition>();
        //InvoiceAddress

        //BillingConditions

    }

    [PrimaryKey(nameof(OrderId), nameof(PositionNr))]
    public class OrderPosition : CreatedModified
    {
        public int PositionNr { get; set; }

        // FK +++++
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        // ++++
        public string DeliveryAddress { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int Amount { get; set; }

        [Column(TypeName = "decimal(5,4)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(12,4"),
         Range(0, int.MaxValue)]
        public decimal Price { get; set; }

        public string PositionState { get; set; } = string.Empty;
    }
}
