using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderMicroservice.Models
{
    public class Order
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public string OrderBy { get; set; } = string.Empty;
        public DateTime DateOrdered { get; set; }
    }
}
