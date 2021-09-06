using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Home_Helper.Data.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public Payee Payee { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PaidDate { get; set; }
        public string ConfirmationNumber { get; set; }
        public bool Recurring { get; set; }
        public bool Paid { get; set; }
    }
}