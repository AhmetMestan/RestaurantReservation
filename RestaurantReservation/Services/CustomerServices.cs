using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Services
{
    public class CustomerServices
    {
        RestaurantReservationContext db = new RestaurantReservationContext();
        public Customers AddCustomer(Customers customers)
        {

            db.Customers.Add(customers);
            db.SaveChanges();

            return customers;
        }

        public List<Customers> GetAllCustomers()
        {
            List<Customers> customers = db.Customers.ToList();
            return customers;
        }

        public void Update(Customers customers)
        {
            var foundCustomer = db.Customers.FirstOrDefault(x => x.Id == customers.Id);

            if (foundCustomer != null)
            {
                foundCustomer.Name = customers.Name;
                foundCustomer.Surname = customers.Surname;
                foundCustomer.EMail = customers.EMail;
                foundCustomer.Phone = customers.Phone;
            }
        }

        public void Delete(Customers customers)
        {
            customers = db.Customers.FirstOrDefault(x=>x.Id ==  customers.Id);
            db.Customers.Remove(customers);
            db.SaveChanges();
        }
    }
}
