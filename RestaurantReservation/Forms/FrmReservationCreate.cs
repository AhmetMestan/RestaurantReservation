using RestaurantReservation.Models;
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
    public partial class FrmReservationCreate : Form
    {
        public FrmReservationCreate()
        {
            InitializeComponent();
        }
        RestaurantReservationContext context = new RestaurantReservationContext();
        Customers customers = new Customers();
        private void FrmReservationCreate_Load(object sender, EventArgs e)
        {
            List<Customers> customers = context.Customers.ToList();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name";
        }

        public override string ToString()
        {
            return customers.Name;
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
