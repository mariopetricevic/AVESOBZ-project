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
    public class ProfileRepository : Subject, IProfileRepository
    {
		private static int _nextID = 1;
		public static ProfileRepository _instance;

		private readonly List<Profile> _listProfiles = new List<Profile>();

		public static ProfileRepository getInstance()
		{
			return _instance ?? (_instance = new ProfileRepository());
		}

		public int getProfiletNum()
		{
			return _listProfiles.Count;
		}

        public Profile getProfileByID(int inProfileID)
        {
			var acc = (from l in _listProfiles where l.Id == inProfileID select l).First();
			return acc;
		}

        public Profile getProfileByName(string inProfileIme, string inProfilePrezime)
        {
			var acc = (from l in _listProfiles where l.Ime == inProfileIme && l.Prezime==inProfilePrezime select l).First();

			if (acc != null)
				return acc;

			throw new Exception();
		}

        public List<Profile> getAllProfiles()
        {
			List<Profile> listProfiles = _listProfiles.OfType<Profile>().ToList();

			return listProfiles;
        }

        public List<int> getAllProfilesIDs()
        {
			return _listProfiles.Select(acc => acc.Id).ToList();
		}

        public bool doesProfileExists(string inProfileIme, string inProfilePrezime)
        {
			var acc = (from l in _listProfiles where l.Ime == inProfileIme && l.Prezime==inProfilePrezime select l).First();

			return acc != null;
		}

        public void addProfile(Profile inProfile)
        {
			if (inProfile.Id == Profile.UndefinedProfileID || _listProfiles.Any(acc => acc.Id == inProfile.Id))
				inProfile.Id = getNewID();                 

			_listProfiles.Add(inProfile);

			NotifyObservers();
		}

        public void deleteProfile(int inProfileID)
        {
			var acc = (from l in _listProfiles where l.Id == inProfileID select l).FirstOrDefault();
			_listProfiles.Remove(acc);

			NotifyObservers();

		}
        public int getNewID()
        {
			int nextID = _nextID;

			_nextID++;

			return nextID;
		}

      
    }
}
