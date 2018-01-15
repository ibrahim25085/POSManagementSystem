using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class OrganizationService
    {
        private OrganizationDataAccess data = new OrganizationDataAccess();
        public IEnumerable<Organization> GetAll()
        {
            return this.data.GetAll();
        }
        public Organization Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(Organization org)
        {
            return this.data.Update(org);
        }
        public int Insert(Organization org)
        {
            return this.data.Insert(org);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
