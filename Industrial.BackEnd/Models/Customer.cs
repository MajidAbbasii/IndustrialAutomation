using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("customer")]
    public class Customer
    {
        public long? Id { get; set; }

        public long? Name { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var customer = obj as Customer;
            if (customer?.Id == null || customer?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, customer.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Customer{" +
                    $"ID='{Id}'" +
                    $", Name='{Name}'" +
                    "}";
        }
    }
}
