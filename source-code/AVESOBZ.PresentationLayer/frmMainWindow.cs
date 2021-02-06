using AVESOBZ.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVESOBZ.PresentationLayer
{
	public partial class frmMainWindow : Form
	{
		private readonly MainFormController _controller;

		public frmMainWindow(MainFormController inController)
		{
			_controller = inController;

			InitializeComponent();
		}

		private void loadDefaultModelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.LoadDefaultModel();
		}

		private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.AddProfile();
		}

		private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.ShowProfiles();
		}
		private void createTicketsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.AddTicket();
		}

		private void viewTicketsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_controller.ShowTickets();
		}

	}
}
