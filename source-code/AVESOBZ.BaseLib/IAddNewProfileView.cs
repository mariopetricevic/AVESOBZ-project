using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.BaseLib
{
    public interface IAddNewProfileView
    {
        bool ShowViewModal();

        string Ime { get; }
        string Prezime { get;}

        string Mjesto { get; }
        string Kontakt { get; }
        string Potvrda { get; }
    }
}
