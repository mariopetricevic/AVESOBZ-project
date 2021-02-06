using AVESOBZ.BaseLib;
using AVESOBZ.Model;
using AVESOBZ.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Controllers
{
	public class MainFormController : IMainFormController
	{
		private bool _defaultModelLoaded = false;
		public readonly IMainFormController mainFormController = null;
		public readonly IWindowFormsFactory _formsFactory = null;
		public readonly IProfileRepository _profileRepository = null;
        public readonly ITicketRepository _ticketRepository=null;
   

		public MainFormController(IWindowFormsFactory inFormFactory, IProfileRepository inProfileRepo, ITicketRepository inTicketRepo)
		{
			_formsFactory = inFormFactory;
			_profileRepository = inProfileRepo;
			_ticketRepository = inTicketRepo;
		
		}
		public void LoadDefaultModel()
		{
			if (_defaultModelLoaded == false)
			{
				using (var ctx=new Context())
                {
					var profile = new Profile(10, "Bruno", "Busic", "Dakovo", "815435", "Dostavljena");
					var profile2 = new Profile(11, "Kreso", "Petricevic", "Osijek", "099453123", "Dostavljena");
					var profile3 = new Profile(12, "Karlo", "Kovacevic", "Crnac", "0912346542", "Dostavljena");
					var profile4 = new Profile(13, "Nikola", "Stipic", "Gasinci", "993422345", "Dostavljena");
					ctx.Profiles.Add(profile);
					ctx.Profiles.Add(profile2);
					ctx.Profiles.Add(profile3);
					ctx.Profiles.Add(profile4);
					ctx.SaveChanges();
                }


				_profileRepository.addProfile(new Profile(1, "Bruno", "Busic", "Dakovo", "815435", "Dostavljena"));
				_profileRepository.addProfile(new Profile(2, "Kreso", "Petricevic", "Osijek", "099453123", "Dostavljena"));
				_profileRepository.addProfile(new Profile(3, "Karlo", "Kovacevic", "Crnac", "0912346542", "Dostavljena"));
				_profileRepository.addProfile(new Profile(4, "Ante", "Milicevic", "Zagreb", "998453234", "Dostavljena"));
				_profileRepository.addProfile(new Profile(5, "Klara", "Serer", "Zagreb", "954328652", "Dostavljena"));
				_profileRepository.addProfile(new Profile(6, "Duje", "Markic", "Split", "983452162", "Dostavljena"));
				_profileRepository.addProfile(new Profile(7, "Nikola", "Stipic", "Gasinci", "993422345", "Dostavljena"));
				_profileRepository.addProfile(new Profile(8, "Davor", "Skocibusic", "Ilok", "9923423424", "Dostavljena"));





				_defaultModelLoaded = true;
			}
		}
	

		public void AddProfile()
		{
			var profileController = new ProfileController();

			var newFrm = _formsFactory.CreateAddNewProfileView();

			profileController.AddNewProfile(newFrm, _profileRepository);
		}
		public void AddTicket()
		{
			var ticketController = new TicketController();
			var newFrm = _formsFactory.CreateAddNewTicketView();
			ticketController.AddNewTicket(newFrm, _ticketRepository);
		}
		public void ShowTickets()
		{
			var ticketController = new TicketController();

			var newFrm = _formsFactory.CreateShowTicketsListView();

			ticketController.ViewTickets(newFrm, _ticketRepository, this);
		}

		public void ShowProfiles()
		{
			var profileController = new ProfileController();

			var newFrm = _formsFactory.CreateShowProfilesListView();

			profileController.ViewProfiles(newFrm, _profileRepository, this);
		}

		public void DeleteProfile(int id)
        {
			id = id + 1;
			
			_profileRepository.deleteProfile(id);
        }
       
    }
}
