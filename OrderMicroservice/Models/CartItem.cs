using System.ComponentModel.DataAnnotations;

namespace OrderMicroservice.Models
{
        public class CartItem
        {
            [Key]
            public int ItemId { get; set; }

            public int CartId { get; set; }

            public int Quantity { get; set; }

            public System.DateTime DateCreated { get; set; }

            public int ProductId { get; set; }

            public string? Username { get; set; }
        }
    }
