using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.BaseLib
{
    public interface IAddNewTicketView
    {
        bool ShowViewModal();

        string price { get; }
     
        string Mjesto1 { get; }
        string Mjesto2 { get; }
     
    }
}
