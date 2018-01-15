using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class ItemService
    {
        private ItemDataAccess data = new ItemDataAccess();
        public IEnumerable<Item> GetAll()
        {
            return this.data.GetAll();
        }
        public Item Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(Item item)
        {
            return this.data.Update(item);
        }
        public int Insert(Item item)
        {
            return this.data.Insert(item);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
