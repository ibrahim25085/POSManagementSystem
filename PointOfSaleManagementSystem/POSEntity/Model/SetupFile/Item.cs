using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public byte Image { get; set; }

        public int itemCategoryID { get; set; }
        public virtual ItemCategory itemCategory { get; set; }
    }
}
