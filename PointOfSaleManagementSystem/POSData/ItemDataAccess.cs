using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class ItemDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<Item> GetAll()
        {
            return this.context.Items.ToList();
        }
        public Item Get(int ID)
        {
            return this.context.Items.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(Item item)
        {
            Item newItem = this.context.Items.FirstOrDefault(x => x.ID == item.ID);
            newItem.Category = item.Category;
            newItem.Code = item.Code;
            newItem.CostPrice = item.CostPrice;
            newItem.Description = item.Description;
            newItem.Image = item.Image;
            newItem.Name = item.Name;
            newItem.Quantity = item.Quantity;
            newItem.SalePrice = item.SalePrice;
            newItem.itemCategoryID = item.itemCategoryID;

            return this.context.SaveChanges();

        }
        public int Insert(Item item)
        {
            this.context.Items.Add(item);
            return this.context.SaveChanges();
        }

        public int Delete(int ID)
        {
            Item newItem = this.context.Items.FirstOrDefault(x => x.ID == ID);
            this.context.Items.Remove(newItem);

            return this.context.SaveChanges();
        }
    }
}
