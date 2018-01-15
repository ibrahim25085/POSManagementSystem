using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class ExpenseItemDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<ExpenseItem> GetAll()
        {
            return this.context.ExpenseItems.ToList();
        }
        public ExpenseItem Get(int ID)
        {
            return this.context.ExpenseItems.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(ExpenseItem Items)
        {
            ExpenseItem expense = this.context.ExpenseItems.FirstOrDefault(x => x.ID == Items.ID);
            expense.Name = Items.Name;
            expense.Description = Items.Description;
            expense.Code = Items.Code;
            expense.expenseCategoryID = Items.expenseCategoryID;
           
            return this.context.SaveChanges();

        }
        public int Insert(ExpenseItem Items)
        {
            this.context.ExpenseItems.Add(Items);
            return this.context.SaveChanges();
        }
        public int Delete(int ID)
        {
            ExpenseItem expense = this.context.ExpenseItems.FirstOrDefault(x => x.ID == ID);
            this.context.ExpenseItems.Remove(expense);

            return this.context.SaveChanges();
        }
    }
}
