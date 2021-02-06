using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model.Factories
{
	public class TicketFactory
	{
		public static Ticket CreateTicket(string Mjesto1, string Mjesto2, string price)
		{
			Ticket retTicket;
			retTicket = new Ticket(Mjesto1, Mjesto2, price);

			return retTicket;
		}
	}
}
