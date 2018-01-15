using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;

namespace POSService
{
    public class CategoryService
    {
        private CategoryDataAccess data = new CategoryDataAccess();
        public IEnumerable<Category> GetAll()
        {
            return this.data.GetAll();
        }
        public Category Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(Category ctg)
        {
            return this.data.Update(ctg);
        }
        public int Insert(Category ctg)
        {
            return this.data.Insert(ctg);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
