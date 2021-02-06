using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model.Repositories
{
    public interface ITicketRepository
    {
		List<Ticket> getAllTickets();
		void addTicket(Ticket inTicket);
		
	}
}
