using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class ExpenseItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }


        public int expenseCategoryID { get; set; }
        public virtual ExpenseCategory expenseCategory { get; set; }
    }
}
