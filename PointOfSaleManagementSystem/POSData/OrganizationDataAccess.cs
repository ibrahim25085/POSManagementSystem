using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class OrganizationDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<Organization> GetAll()
        {
            return this.context.Organizations.ToList();
        }
        public Organization Get(int ID)
        {
            return this.context.Organizations.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(Organization org)
        {
            Organization organization = this.context.Organizations.FirstOrDefault(x => x.ID == org.ID);
            organization.Name = org.Name;
            organization.Address = org.Address;
            organization.Code = org.Code;
            organization.Image = org.Image;
            organization.Contact = org.Contact;
           

            return this.context.SaveChanges();

        }
        public int Insert(Organization org)
        {
            this.context.Organizations.Add(org);
            return this.context.SaveChanges();
        }

        public int Delete(int ID)
        {
            Organization organization = this.context.Organizations.FirstOrDefault(x => x.ID == ID);
            this.context.Organizations.Remove(organization);

            return this.context.SaveChanges();
        }
    }
}
