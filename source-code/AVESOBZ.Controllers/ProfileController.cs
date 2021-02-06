using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVESOBZ.BaseLib;
using AVESOBZ.Model;
using AVESOBZ.Model.Factories;
using AVESOBZ.Model.Repositories;

namespace AVESOBZ.Controllers
{
    public class ProfileController
    {

		public void AddNewProfile(IAddNewProfileView inForm, IProfileRepository profileRepository)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string Ime = inForm.Ime;
					string Prezime = inForm.Prezime;
					string Mjesto = inForm.Mjesto;
					string Kontakt = inForm.Kontakt;
					string Potvrda = inForm.Potvrda;

					int ID = profileRepository.getNewID();

				

					Profile newProfile = ProfileFactory.CreateProfile(ID,Ime,Prezime,Mjesto, Kontakt, Potvrda);

					profileRepository.addProfile(newProfile);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Dogodio se EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}


		public void DeleteProfile(int id, IProfileRepository profileRepository)
        {
			
				try
				{
					profileRepository.deleteProfile(id);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Dogodio se EXCEPTION: " + ex.Message);
					throw;
				}
			
		}

		public void ViewProfiles(IShowProfilesListView inForm, IProfileRepository profileRepository, IMainFormController mainController)
		{
			//dohvati profile i prosljedi ih Viewu
			List<Profile> listProfiles = profileRepository.getAllProfiles();

			inForm.ShowModaless(mainController, listProfiles);
		}
	}
}
