using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class ExpenseCategory
    {
        public int ID { get; set; }
        public string CategoryType { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public int categoryID { get; set; }
        public virtual Category category { get; set; }
        public virtual ICollection<ExpenseItem> ExpenseItemList { get; set; }
    }
}
