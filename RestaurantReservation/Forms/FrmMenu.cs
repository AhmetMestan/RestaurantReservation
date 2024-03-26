using RestaurantReservation.Models;
using RestaurantReservation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservation.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        MenuServices menuServices = new MenuServices();
        RestaurantReservationContext context = new RestaurantReservationContext();

        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu();
                menu.Title = txtTitle.Text;
                menu.Description = txtDescription.Text;
                menu.Price = Convert.ToDecimal(txtPrice.Text);

                menuServices.MenuAdd(menu);
                LoadData();
                MessageBox.Show("New Menu Added");
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured");
            }
            


        }

        public void LoadData()
        {
            dataGridMenu.DataSource = menuServices.GetAllMenu();
        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        int selectedId;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt32(dataGridMenu.CurrentRow.Cells["Id"].Value);
            var menu = context.Menu.FirstOrDefault(x => x.Id == selectedId);
            if(menu != null)
            {
                menuServices.Delete(menu);
            }
            LoadData();
        }

    }
}
