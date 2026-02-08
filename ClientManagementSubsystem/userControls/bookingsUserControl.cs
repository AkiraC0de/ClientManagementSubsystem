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
            bookingListPanel.Controls.Clear();
            bookingListPanel.SuspendLayout();

            for (int i = 0; i < 12; i++)
            {
                BookingCard card = new BookingCard();

                card.VehicleName = "Toyota Vios";
                card.ClientName = "John Doe";
                card.BookingID = i;
                
                card.OnSelect += (s, e) =>
                {
                    MessageBox.Show($"You clicked booking #{card.BookingID}");
                 };

                bookingListPanel.Controls.Add(card);
            }

            bookingListPanel.ResumeLayout();
            CenterCards();
        }

        private void CenterCards()
        {
            if (bookingListPanel.Controls.Count == 0) return;

            // Use the first control to get the base dimensions
            Control firstCard = bookingListPanel.Controls[0];

            // Total width one card occupies (Width + Left Margin + Right Margin)
            int cardFullWidth = firstCard.Width + firstCard.Margin.Horizontal;

            // Available width (ClientSize should exclude scrollbar width)
            int availableWidth = bookingListPanel.ClientSize.Width - bookingListPanel.Padding.Horizontal;

            // Calculate how many cards can fit
            int cardsPerRow = availableWidth / cardFullWidth;

            // Safety check: if panel is smaller than one card
            if (cardsPerRow <= 0) cardsPerRow = 1;

            // Total width of the "block" of cards
            int totalContentWidth = cardsPerRow * cardFullWidth;

            // Calculate the left padding needed to center that block
            int lateralPadding = (bookingListPanel.ClientSize.Width - totalContentWidth) / 2;

            // Apply the padding (keeping top/bottom as they were)
            // We use Math.Max to ensure padding is never negative
            bookingListPanel.Padding = new Padding(Math.Max(0, lateralPadding), bookingListPanel.Padding.Top, 0, 0);
        }
    }
}
