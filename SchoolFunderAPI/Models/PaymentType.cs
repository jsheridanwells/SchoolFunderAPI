using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFunderAPI.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string BankId { get; set; }
        public string AccountNumber{ get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UserId { get; set; }
    }
}
