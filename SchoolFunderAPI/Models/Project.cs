using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFunderAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int SchoolId { get; set; }
        public string GradeLevel { get; set; }
        public int FundingGoal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
