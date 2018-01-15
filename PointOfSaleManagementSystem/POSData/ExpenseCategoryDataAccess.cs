using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class ExpenseCategoryDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<ExpenseCategory> GetAll()
        {
            return this.context.ExpenseCategoris.ToList();
        }
        public ExpenseCategory Get(int ID)
        {
            return this.context.ExpenseCategoris.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(ExpenseCategory category)
        {
            ExpenseCategory Expense = this.context.ExpenseCategoris.FirstOrDefault(x => x.ID == category.ID);
            Expense.CategoryType = category.CategoryType;
            Expense.Name = category.Name;
            Expense.Description = category.Description;
            Expense.categoryID = category.categoryID;
            Expense.Code = category.Code;
            return this.context.SaveChanges();

        }
        public int Insert(ExpenseCategory category)
        {
            this.context.ExpenseCategoris.Add(category);
            return this.context.SaveChanges();
        }
        public int Delete(int ID)
        {
            ExpenseCategory Expense = this.context.ExpenseCategoris.FirstOrDefault(x => x.ID == ID);
            this.context.ExpenseCategoris.Remove(Expense);

            return this.context.SaveChanges();
        }
    }
}
