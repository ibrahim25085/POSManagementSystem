using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class OutletDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<Outlet> GetAll()
        {
            return this.context.Outlets.ToList();
        }
        public Outlet Get(int ID)
        {
            return this.context.Outlets.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(Outlet outlet)
        {
            Outlet newOutlet = this.context.Outlets.FirstOrDefault(x => x.ID == outlet.ID);
            newOutlet.Name = outlet.Name;
            newOutlet.ContactNo = outlet.ContactNo;
            newOutlet.Code = outlet.Code;
            newOutlet.organizationID = outlet.organizationID;

            return this.context.SaveChanges();

        }
        public int Insert(Outlet outlet)
        {
            this.context.Outlets.Add(outlet);
            return this.context.SaveChanges();
        }

        public int Delete(int ID)
        {
            Outlet newOutlet = this.context.Outlets.FirstOrDefault(x => x.ID == ID);
            this.context.Outlets.Remove(newOutlet);

            return this.context.SaveChanges();
        }
    }
}
