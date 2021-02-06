using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model.Repositories
{
    public interface IProfileRepository
    {
		Profile getProfileByID(int inProfileID);
		
		Profile getProfileByName(string inProfileIme, string inProfilePrezime);
		List<Profile> getAllProfiles();
		List<int> getAllProfilesIDs();

		int getNewID();
		bool doesProfileExists(string inProfileIme, string inProfilePrezime);

		void addProfile(Profile inProfile);
		void deleteProfile(int inProfileID);
	}
}
