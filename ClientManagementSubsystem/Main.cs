using ClientManagementSubsystem.userControls;
using FontAwesome.Sharp;
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
    public partial class Main : Form
    {
        private ButtonSelection btnSelection;

        public Main()
        {
            InitializeComponent();

            btnSelection = new ButtonSelection(
                Color.FromArgb(255, 56, 189, 248),
                Color.FromArgb(255, 230, 241, 247)
            );
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnSelection.RegisterButton(dashboardBtn, dashboardSelected);
            btnSelection.RegisterButton(bookingsBtn, bookingsSelected);
            btnSelection.RegisterButton(outboundBtn, outboundSelected);
            btnSelection.RegisterButton(inboundBtn, inboundSelected);
            btnSelection.RegisterButton(damagesBtn, damagesSelected);
            btnSelection.RegisterButton(personalBtn, personalSelected);

            showControl(new dashboardUserControl());
            btnSelection.ActivateButton(dashboardBtn);
        }

        // Logic for loading User Controls
        private void showControl(Control addevent)
        {
            containerPanel.Controls.Clear();
            addevent.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(addevent);
        }

        // Button click events

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            showControl(new dashboardUserControl());
            btnSelection.ActivateButton(sender);
            activityLabel.Text = "Dashboard";
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            showControl(new bookingsUserControl());
            btnSelection.ActivateButton(sender);
            activityLabel.Text = "Bookings";
        }

        private void personalBtn_Click(object sender, EventArgs e)
        {
            showControl(new personalUserControl());
            btnSelection.ActivateButton(sender);
            activityLabel.Text = "Personal Details";
        }

        private void outboundBtn_Click(object sender, EventArgs e)
        {
            showControl(new outboundUserControl());
            btnSelection.ActivateButton(sender);
            activityLabel.Text = "Outbound Vehicles";
        }

        private void inboundBtn_Click(object sender, EventArgs e)
        {
            showControl(new inboundUserControl());
            btnSelection.ActivateButton(sender);
            activityLabel.Text = "Inbound Vehicles";
        }

        private void damagesBtn_Click(object sender, EventArgs e)
        {
            showControl(new damagesUserControl());
            btnSelection.ActivateButton(sender);
            activityLabel.Text = "Damages Report";
        }

        // Mouse Events

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            btnSelection.OnMouseEnter(sender);
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            btnSelection.OnMouseLeave(sender);
        }
    }
}
