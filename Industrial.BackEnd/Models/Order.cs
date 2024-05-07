using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("order")]
    public class Order 
    {
        public long? Id { get; set; }

        public DateTime? OrderDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public long? PaymentId { get; set; }
        public Payment Payment { get; set; }
        public long? ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
        public long? CustomerId { get; set; }
        public Customer Customer { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var order = obj as Order;
            if (order?.Id == null || order?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, order.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Order{" +
                    $"ID='{Id}'" +
                    $", OrderDate='{OrderDate}'" +
                    $", TotalPrice='{TotalPrice}'" +
                    "}";
        }
    }
}
