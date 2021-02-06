using AVESOBZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.BaseLib
{
    public interface IShowProfilesListView
    {
        void ShowModaless(IMainFormController inMainController, List<Profile> inListProfile);
    }
}
