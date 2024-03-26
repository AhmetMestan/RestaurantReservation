using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Services
{
    public class ReservationServices

    {
        RestaurantReservationContext context = new RestaurantReservationContext();
        public Reservations AddReservation(Reservations reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return reservation;
        }  

        public List<Reservations> GetReservations()
        {
            List<Reservations> reservations = context.Reservations.ToList();
            return reservations;
        }
    }
}
