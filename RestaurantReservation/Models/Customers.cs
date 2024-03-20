using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class Customers : BaseClass
    {
    
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public int Phone { get; set; }
        public string? Address { get; set; }
    }
}
