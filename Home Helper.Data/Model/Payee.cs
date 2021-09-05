using System;
using System.Collections.Generic;

namespace Home_Helper.Data.Model
{
    public class Payee
    {
        public int Id { get; set; }
        public string PayeeNumber { get; set; }
        public string PayeeName { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
