using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.BaseLib
{
	public interface IWindowFormsFactory
	{
		IAddNewProfileView CreateAddNewProfileView();
		IShowProfilesListView CreateShowProfilesListView();

		IAddNewTicketView CreateAddNewTicketView();
		IShowTicketsListView CreateShowTicketsListView();

		IDeleteProfileView CreateDeleteProfileView();


	}
}
