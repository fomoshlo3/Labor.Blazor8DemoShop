using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateOnly OrderDate { get; set; }
        public int Discount { get; set; }

        //ForeignKeys
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderPosition> Positions { get; set; } = new List<OrderPosition>();
        //InvoiceAddress

        //BillingConditions

    }

    [PrimaryKey(nameof(OrderId), nameof(PositionNr))]
    public class OrderPosition
    {
        public int PositionNr { get; set; }
        
        // FK +++++
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        //public int DeliveryAddressId { get; set; }
        // ++++
        public int Amount { get; set; }

        public int Discount { get; set; }
        public decimal Price { get; set; }
    }
}
