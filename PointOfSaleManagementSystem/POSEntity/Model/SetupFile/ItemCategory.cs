using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class ItemCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte Image { get; set; }

        public string CategoryType { get; set; }

        public virtual ICollection<Item> ItemList { get; set; }

        public int categoryID { get; set; }
        public virtual Category category { get; set; }
    }
}
