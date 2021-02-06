using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model.Factories
{
    public class ProfileFactory
    {
		
		public static Profile CreateProfile(int inID, string Ime, string Prezime, string Mjesto, string Kontakt, string potvrda)
		{
			Profile retProfile;
			retProfile = new Profile(inID, Ime, Prezime, Mjesto, Kontakt, potvrda);


			return retProfile;
		}
	}
}
