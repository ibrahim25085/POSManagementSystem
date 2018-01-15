 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
   public class PartyDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<Party> GetAll()
        {
            return this.context.Parties.ToList();
        }
        public Party Get(int ID)
        {
            return this.context.Parties.FirstOrDefault(x => x.ID == ID);
        }

        public int Insert(Party party)
        {
            this.context.Parties.Add(party);
            return this.context.SaveChanges();
        }
        public int Update(Party partyType)
        {
            Party party = this.context.Parties.FirstOrDefault(x => x.ID == partyType.ID);
            party.Address = partyType.Address;
            party.Code = partyType.Code;
            party.ContactNo = partyType.ContactNo;
            party.Email = partyType.Email;
            party.Image = partyType.Image;
            party.PartyType = partyType.PartyType;
            party.organizationID = partyType.organizationID;
         

            return this.context.SaveChanges();

        }

        public int Delete(int ID)
        {
            Party party = this.context.Parties.FirstOrDefault(x => x.ID == ID);
            this.context.Parties.Remove(party);

            return this.context.SaveChanges();
        }
    }
}
