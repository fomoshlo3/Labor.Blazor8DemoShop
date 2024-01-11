using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class CreatedModified
    {

        public DateTime Created { get; set; }

        [StringLength(450)]
        public string CreatedBy { get; set; } = String.Empty;

        public DateTime? Modified { get; set; }

        [StringLength(450)]
        public string? ModifiedBy { get; set; }

        [Required]
        [ForeignKey(nameof(CreatedBy))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ApplicationUser UserCreated { get; set; }

        [ForeignKey(nameof(ModifiedBy))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ApplicationUser? UserModified { get; set;}

    }
}
