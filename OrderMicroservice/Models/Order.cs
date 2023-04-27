using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderMicroservice.Models
{
    public class Order
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string? Username { get; set; } = string.Empty;

        [Required]
        [StringLength(256)]
        public string? FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(256)]
        public string? LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(256)]
        public string? Address { get; set; } = string.Empty;

        [Required]
        [StringLength(40)]
        public string? City { get; set; } = string.Empty;

        [StringLength(40)]
        public string? State { get; set; }

        [StringLength(10)]
        public string? PostalCode { get; set; } = string.Empty;

        [StringLength(40)]
        public string? Country { get; set; } = string.Empty;

        [StringLength(24)]
        public string? Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Address is required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public string? PaymentTransactionId { get; set; } = string.Empty;

        public bool HasBeenShipped { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; } = new List<OrderDetail>();
    }

}
