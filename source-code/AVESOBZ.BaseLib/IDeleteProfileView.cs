using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.BaseLib
{
    public interface IDeleteProfileView
    {
        bool ShowViewModal();

        int Id { get; }

        string Ime { get; }
        string Prezime { get; }

        string Mjesto { get; }
        bool? Potvrda { get; set; }
    }
}
