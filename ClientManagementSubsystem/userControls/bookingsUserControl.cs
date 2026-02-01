using ClientManagementSubsystem.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementSubsystem
{
    public partial class bookingsUserControl : UserControl
    {
        public bookingsUserControl()
        {
            InitializeComponent();
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
            LoadBookings();
        }

        private void pendingBtn_Click(object sender, EventArgs e)
        {
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
        }

        private void approvedBtn_Click(object sender, EventArgs e)
        {
            approvedSelected.Visible = true;
            pendingSelected.Visible = false;
        }

        public void LoadBookings()
        {
            bookingsPanel.Controls.Clear();
            bookingsPanel.SuspendLayout();

            for (int i = 0; i < 10; i++)
            {
                BookingCard card = new BookingCard();

                card.VehicleName = "Toyota Vios " + i;
                card.ClientName = "John Doe";
                card.BookingID = i;

                card.OnSelect += (s, e) =>
                {
                    MessageBox.Show($"You clicked booking #{card.BookingID}");
                 };

                bookingsPanel.Controls.Add(card);
            }

            bookingsPanel.ResumeLayout();
        }
    }
}
