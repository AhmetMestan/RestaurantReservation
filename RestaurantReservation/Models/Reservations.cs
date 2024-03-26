using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class Reservations : BaseClass
    {
        public int CustomersId { get; set; }
        [ForeignKey("CustomersId")]
        public Customers Customers { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Note { get; set; }

    }
}
