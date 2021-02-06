using AVESOBZ.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model
{
    public class Ticket: ITicketRepository
    {
        public ITicketRepository ticketRepository;

        public Ticket(string inMjesto1, string inMjesto2, string inPrice)
        {
            Price = inPrice;
            Mjesto1 = inMjesto1;
            Mjesto2 = inMjesto2;
        }
        public Ticket(int inId, string inMjesto1, string inMjesto2, string inPrice)
        {
            id = inId;
            Price = inPrice;
            Mjesto1 = inMjesto1;
            Mjesto2 = inMjesto2;
        }
        public int id;
        public string Price;
        public string Mjesto1;
        public string Mjesto2;

        public List<Ticket> getAllTickets()
        {
            throw new NotImplementedException();
        }

        public void addTicket(Ticket inTicket)
        {
            throw new NotImplementedException();
        }
    }
}
