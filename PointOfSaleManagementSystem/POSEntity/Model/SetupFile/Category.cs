using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
   public class Category
    {
        public int ID { get; set; }
        public string Nmae { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte Image { get; set; }


        public virtual ICollection<ItemCategory> ItemCategoriesList { get; set; }
        public virtual ICollection<ExpenseCategory> ExpenseCategoryList { get; set; }
    }
}
