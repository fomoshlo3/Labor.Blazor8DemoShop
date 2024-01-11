namespace MyFirstWebShop.Data.DTOs
{
    public class CustomerDetailDTO
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public DateOnly? Birthday { get; set; }

        public int GenderId { get; set; }

        public string GenderName { get; set;} = string.Empty;

        public string? PaymentCondition { get; set; }

        public decimal? Discount { get; set; }
    }
}
