using AVESOBZ.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model
{
    public class Profile : EntityBase<int>
    {
        public IProfileRepository prfileRepository;

        public static readonly int UndefinedProfileID = -1;
        
        public Profile(int inID, string inIme, string inPrezime, string inMjesto, string inKontakt, string inPotvrda) : base(inID)
        {
            Ime = inIme;
            Prezime = inPrezime;
            Mjesto = inMjesto;
            
            Kontakt = inKontakt;
            Potvrda = inPotvrda;
        }
     

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mjesto { get; set; }
       
        public string Kontakt { get; set; }
        public string Potvrda { get; set; }

    }
}
