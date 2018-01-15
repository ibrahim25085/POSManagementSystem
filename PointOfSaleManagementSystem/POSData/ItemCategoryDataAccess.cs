using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class ItemCategoryDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<ItemCategory> GetAll()
        {
            return this.context.ItemCategories.ToList();
        }
        public ItemCategory Get(int ID)
        {
            return this.context.ItemCategories.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(ItemCategory category)
        {
            ItemCategory item = this.context.ItemCategories.FirstOrDefault(x => x.ID == category.ID);
            item.Name = category.Name;
            item.CategoryType = category.CategoryType;
            item.Image = category.Image;
            item.Description = category.Description;
            item.categoryID = category.categoryID;

            return this.context.SaveChanges();

        }
        public int Insert(ItemCategory category)
        {
            this.context.ItemCategories.Add(category);
            return this.context.SaveChanges();
        }
        public int Delete(int ID)
        {
            ItemCategory item = this.context.ItemCategories.FirstOrDefault(x => x.ID == ID);
            this.context.ItemCategories.Remove(item);

            return this.context.SaveChanges();
        }
    }
}
