using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVESOBZ.Model
{
    public class Context: DbContext
    {
        public Context(): base()
        {

        }
        public DbSet<Profile> Profiles { get; set; }




       // public DbSet<Ticket> Tickets { get; set; }
    }
}
