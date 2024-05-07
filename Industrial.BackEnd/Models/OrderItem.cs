using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("order_item")]
    public class OrderItem
    {
        public long? Id { get; set; }

        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public long? OrderId { get; set; }
        public Order Order { get; set; }
        public long? ProductId { get; set; }
        public Product Product { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var orderItem = obj as OrderItem;
            if (orderItem?.Id == null || orderItem?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, orderItem.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "OrderItem{" +
                    $"ID='{Id}'" +
                    $", Quantity='{Quantity}'" +
                    $", Price='{Price}'" +
                    "}";
        }
    }
}
