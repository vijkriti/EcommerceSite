using System;
using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
        public string UserId { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }
    }
}
