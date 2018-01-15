using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
   public class PartyService
    {
        private PartyDataAccess data = new PartyDataAccess();

        public IEnumerable<Party> GetAll()
        {
            return this.data.GetAll();
        }
        public Party Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(Party party)
        {
            return this.data.Update(party);
        }
        public int Insert(Party party)
        {
            return this.data.Insert(party);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
