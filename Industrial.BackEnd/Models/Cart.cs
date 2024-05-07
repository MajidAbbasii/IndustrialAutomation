using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("cart")]
    public class Cart
    {
        public long? Id { get; set; }

        public int? Quantity { get; set; }
        public long? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long? ProductId { get; set; }
        public Product Product { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var cart = obj as Cart;
            if (cart?.Id == null || cart?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, cart.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Cart{" +
                    $"ID='{Id}'" +
                    $", Quantity='{Quantity}'" +
                    "}";
        }
    }
}
