using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("product")]
    public class Product
    {
        public long? Id { get; set; }

        public string? SKU { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public long? CategoryId { get; set; }
        public Category Category { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var product = obj as Product;
            if (product?.Id == null || product?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, product.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Product{" +
                    $"ID='{Id}'" +
                    $", SKU='{SKU}'" +
                    $", Description='{Description}'" +
                    $", Price='{Price}'" +
                    $", Stock='{Stock}'" +
                    "}";
        }
    }
}
