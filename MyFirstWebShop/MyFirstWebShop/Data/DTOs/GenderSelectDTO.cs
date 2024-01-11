using System.ComponentModel.DataAnnotations;

namespace MyFirstWebShop.Data.DTOs
{
    public class GenderSelectDTO
    {
        [Key]
        public int GenderId { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; } = string.Empty;

    }
}
