using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Services
{
    
    public class MenuServices
    {
     RestaurantReservationContext context = new RestaurantReservationContext();

        public Menu MenuAdd (Menu menu)
        {
            context.Menu.Add (menu);
            context.SaveChanges();
            return menu;
        }

        public void Delete(Menu menu)
        {
            menu = context.Menu.FirstOrDefault(x => x.Id == menu.Id);

                context.Menu.Remove(menu);
                context.SaveChanges ();
        }

        public void Update(Menu menu)
        {
            var foundmenu = context.Menu.FirstOrDefault(x=>x.Id == menu.Id);

            if (foundmenu != null)
            {
                foundmenu.Title = menu.Title;
                foundmenu.Description = menu.Description;
                foundmenu.Price = menu.Price;
            }
        }

        public List<Menu> GetAllMenu()
        {
            List<Menu> menus = context.Menu.ToList();
            return menus;
        }


    }
}
