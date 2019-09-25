using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appTeste.Models.Enums;

namespace appTeste.Models
{
    public class SalesRecord
    {
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; } /*using SuperApplication.Models.Enums;*/

        /*Propriedades para associação*/
        public Seller Seller { get; set; }
    }
}
