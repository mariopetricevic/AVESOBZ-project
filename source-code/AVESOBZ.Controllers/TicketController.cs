using AVESOBZ.BaseLib;
using AVESOBZ.Model;
using AVESOBZ.Model.Factories;
using AVESOBZ.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVESOBZ.Controllers
{
    public class TicketController
    {



		public void AddNewTicket(IAddNewTicketView inForm, ITicketRepository ticketRepository)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string price = inForm.price;
					string Mjesto1 = inForm.Mjesto1;
					string Mjesto2 = inForm.Mjesto2;
	

					Ticket newTicket = TicketFactory.CreateTicket(Mjesto1, Mjesto2, price);

					ticketRepository.addTicket(newTicket);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Dogodio se EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}


		public void ViewTickets(IShowTicketsListView inForm, ITicketRepository ticketRepository, IMainFormController mainController)
		{
			List<Ticket> listTickets = ticketRepository.getAllTickets();
			inForm.ShowModaless(mainController, listTickets);
		}
	}
}
