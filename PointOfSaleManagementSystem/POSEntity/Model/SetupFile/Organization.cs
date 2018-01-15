using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class Organization
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public byte Image { get; set; }
        public string Address { get; set; }


        public virtual ICollection<Outlet> OutletList { get; set; }

        public virtual ICollection<Party> PartyList { get; set; }
    }
}
