using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;
using POSData;
namespace POSService
{
    public class ExpenseCategoryService
    {
        private ExpenseCategoryDataAccess data = new ExpenseCategoryDataAccess();
        public IEnumerable<ExpenseCategory> GetAll()
        {
            return this.data.GetAll();
        }
        public ExpenseCategory Get(int ID)
        {
            return this.data.Get(ID);
        }
        public int Update(ExpenseCategory category)
        {
            return this.data.Update(category);
        }
        public int Insert(ExpenseCategory category)
        {
            return this.data.Insert(category);
        }
        public int Delete(int ID)
        {
            return this.data.Delete(ID);
        }
    }
}
