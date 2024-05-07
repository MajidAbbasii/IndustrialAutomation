using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("shipment")]
    public class Shipment
    {
        public long? Id { get; set; }

        public DateTime? ShipmentDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public long? CustomerId { get; set; }
        public Customer Customer { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var shipment = obj as Shipment;
            if (shipment?.Id == null || shipment?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, shipment.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Shipment{" +
                    $"ID='{Id}'" +
                    $", ShipmentDate='{ShipmentDate}'" +
                    $", Address='{Address}'" +
                    $", City='{City}'" +
                    "}";
        }
    }
}
