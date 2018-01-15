using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class ItemCategoryService
    {
        private ItemCategoryDataAccess data = new ItemCategoryDataAccess();
        public IEnumerable<ItemCategory> GetAll()
        {
            return this.data.GetAll();
        }
        public ItemCategory Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(ItemCategory item)
        {
            return this.data.Update(item);
        }
        public int Insert(ItemCategory item)
        {
            return this.data.Insert(item);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
