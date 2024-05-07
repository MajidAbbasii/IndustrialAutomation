using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industrial.BackEnd.Models
{
    [Table("payment")]
    public class Payment
    {
        public long? Id { get; set; }

        public DateTime? PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public decimal? Amount { get; set; }
        public long? CustomerId { get; set; }
        public Customer Customer { get; set; }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            var payment = obj as Payment;
            if (payment?.Id == null || payment?.Id == 0 || Id == 0) return false;
            return EqualityComparer<long>.Equals(Id, payment.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "Payment{" +
                    $"ID='{Id}'" +
                    $", PaymentDate='{PaymentDate}'" +
                    $", PaymentMethod='{PaymentMethod}'" +
                    $", Amount='{Amount}'" +
                    "}";
        }
    }
}
