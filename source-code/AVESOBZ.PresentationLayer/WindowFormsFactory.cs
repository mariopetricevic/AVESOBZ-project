using AVESOBZ.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
	

        public IAddNewProfileView CreateAddNewProfileView()
        {
			var newFrm = new frmAddProfile();

			return newFrm;
        }

        public IAddNewTicketView CreateAddNewTicketView()
        {
            var newFrm = new frmAddTicket();
            return newFrm;
        }

        public IDeleteProfileView CreateDeleteProfileView()
        {
            throw new NotImplementedException();
        }

      

        public IShowProfilesListView CreateShowProfilesListView()
		{
			var newFrm = new frmViewProfiles();

			return newFrm;
		}

        public IShowTicketsListView CreateShowTicketsListView()
        {
            var newFrm = new frmViewTickets();

            return newFrm;
        }
    }
}
