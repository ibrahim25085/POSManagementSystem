using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class OutletService
    {
        private OutletDataAccess data = new OutletDataAccess();

        public IEnumerable<Outlet> GetAll()
        {
            return this.data.GetAll();
        }
        public Outlet Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(Outlet outlet)
        {
            return this.data.Update(outlet);
        }
        public int Insert(Outlet outlet)
        {
            return this.data.Insert(outlet);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
