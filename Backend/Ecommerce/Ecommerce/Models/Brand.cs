﻿using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Product> Products { get; set; }
    }
}
