using AVESOBZ.BaseLib;
using AVESOBZ.Model;
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
    public partial class frmViewTickets : Form, IShowTicketsListView
    {
		private List<Ticket> _listTickets = null;
		private IMainFormController _mainController = null;

		public frmViewTickets()
		{
			InitializeComponent();
		}

		public void ShowModaless(IMainFormController inMainController, List<Ticket> inListTickets)
		{
			_mainController = inMainController;
			_listTickets = inListTickets;

			UpdateList();

			this.Show();
		}


		private void listTickets_DoubleClick(object sender, EventArgs e)
		{
			if (listTickets.SelectedItems[0] != null)
			{
				
				string Mjesto1 = listTickets.SelectedItems[0].SubItems[0].Text;
				string Mjesto2 = listTickets.SelectedItems[0].SubItems[0].Text;
				string Price = listTickets.SelectedItems[0].SubItems[0].Text;

			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UpdateList()
		{
			for (int i = 0; i < _listTickets.Count(); i++)
			{
				Ticket acc = _listTickets[i];

			
				string Mjesto1 = acc.Mjesto1;
				string Mjesto2 = acc.Mjesto2;
				string Price = acc.Price;
				ListViewItem lvt = new ListViewItem(acc.Mjesto1);
				lvt.SubItems.Add(Mjesto2);
				lvt.SubItems.Add(Price);
				


				listTickets.Items.Add(lvt);
			}
		}
	}
}
