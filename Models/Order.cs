using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Istagrow.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Plan { get; set; }
        public int Followers { get; set; }
        public int Price { get; set; }
        public bool IsPaid { get; set; }
        public bool IsActive { get; set; }
        public bool IsComplete { get; set; }
    }
}
