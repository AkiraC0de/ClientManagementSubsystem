using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementSubsystem.userControls
{
    public partial class BookingCard : UserControl
    {
        public event EventHandler OnSelect;

        public BookingCard()
        {
            InitializeComponent();

            this.Click += Card_Clicked;

            WireAllControls(this);
        }

        private void WireAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += Card_Clicked;

                if (c.HasChildren)
                {
                    WireAllControls(c);
                }
            }
        }

        private void Card_Clicked(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        public string VehicleName { get { return lblVehicle.Text; } set { lblVehicle.Text = value; } }
        public string ClientName { get { return lblClient.Text; } set { lblClient.Text = value; } }
        public int BookingID
        {
            get
            {
                return int.TryParse(lblBookingNum.Text, out int bookingID) ? bookingID : -1;
            }
            set
            {
                lblBookingNum.Text = value.ToString();
            }
        }
    }
}