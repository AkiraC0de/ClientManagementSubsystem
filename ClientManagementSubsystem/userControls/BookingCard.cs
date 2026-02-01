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
        // 1. Create a custom event that the Main Form can listen to
        public event EventHandler OnSelect;

        public BookingCard()
        {
            InitializeComponent();

            // 2. Wire up the click event for the card itself
            this.Click += (s, e) => OnSelect?.Invoke(this, e);

            // 3. IMPORTANT: Wire up the click for ALL child controls (labels, panels)
            // so clicking the text also triggers the card selection.
            foreach (Control c in this.Controls)
            {
                c.Click += (s, e) => OnSelect?.Invoke(this, e);
                // If you have nested panels, you might need a recursive function here
            }
        }

        // 4. Properties to easily set data from the loop
        public string VehicleName { get { return lblVehicle.Text; } set { lblVehicle.Text = value; } }
        public string ClientName { get { return lblClient.Text; } set { lblClient.Text = value; } }
        public int BookingID { get; set; } // Hidden ID for database logic
    }
}