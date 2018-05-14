using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFunderAPI.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId{ get; set; }
        public decimal Amount { get; set; }
        public bool? Anonymous{ get; set; }
        public int PaymentTypeId { get; set; }

    }
}
