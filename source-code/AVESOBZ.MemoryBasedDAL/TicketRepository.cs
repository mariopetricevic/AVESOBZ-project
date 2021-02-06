using AVESOBZ.BaseLib;
using AVESOBZ.Model;
using AVESOBZ.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.MemoryBasedDAL
{
    public class TicketRepository : Subject, ITicketRepository
    {
		
		public static TicketRepository _instance;

		private readonly List<Ticket> _listTickets = new List<Ticket>();

		public static TicketRepository getInstance()
		{
			return _instance ?? (_instance = new TicketRepository());
		}




		public List<Ticket> getAllTickets()
		{
			List<Ticket> listTickets = _listTickets.OfType<Ticket>().ToList();

			return listTickets;
		}

		public void addTicket(Ticket inTicket)
		{
	

			_listTickets.Add(inTicket);

			NotifyObservers();
		}


      
    }
}
