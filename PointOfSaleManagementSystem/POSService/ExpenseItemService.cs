using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class ExpenseItemService
    {
        private ExpenseItemDataAccess data = new ExpenseItemDataAccess();

        public IEnumerable<ExpenseItem> GetAll()
        {
            return this.data.GetAll();
        }
        public ExpenseItem Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(ExpenseItem item)
        {
            return this.data.Update(item);
        }
        public int Insert(ExpenseItem item)
        {
            return this.data.Insert(item);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
