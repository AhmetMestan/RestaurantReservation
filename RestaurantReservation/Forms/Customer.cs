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

namespace RestaurantReservation
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        CustomerServices customerServices = new CustomerServices();
        RestaurantReservationContext db = new RestaurantReservationContext();

        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customers customers = new Customers();
                customers.Name = txtName.Text;
                customers.Surname = txtSurname.Text;
                customers.EMail = txtEmail.Text;
                customers.Phone = txtPhone.Text;


                customerServices.AddCustomer(customers);
                LoadData();
                MessageBox.Show("Customer has been registered to the system!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void LoadData()
        {
            dataGridView1.DataSource = customerServices.GetAllCustomers();
        }

        public void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        int selectedCustomerId;
        public void btnDelete_Click(object sender, EventArgs e)
        {
            selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            var customer = db.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);
            if (customer != null)
            {
                customerServices.Delete(customer);
            }
            LoadData();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                var customer = db.Customers.FirstOrDefault(y => y.Id == selectedCustomerId);
                if (customer != null)
                {
                    customerServices.Update(customer);
                    db.SaveChanges();
                    LoadData();

                    MessageBox.Show("Customers updated successsfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            var customer = db.Customers.FirstOrDefault(x=> x.Id == selectedCustomerId);

            txtName.Text = customer.Name;
            txtSurname.Text=customer.Surname;
            txtEmail.Text = customer.EMail;
            txtPhone.Text = customer.Phone;
        }
    }
}
