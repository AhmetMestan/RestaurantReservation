﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class Orders : BaseClass
    {
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
        public int ReservationId { get; set; }
        [ForeignKey("ReservationId")]
        public Reservations Reservations { get; set; }


    }
}
