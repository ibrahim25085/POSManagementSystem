using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class CategoryDataAccess
    {
        private POSDbContext context = new POSDbContext();

        public IEnumerable<Category> GetAll()
        {
            return this.context.Categories.ToList();
        }
        public Category Get(int ID)
        {
            return this.context.Categories.FirstOrDefault(x => x.ID == ID);
        }
        public int Update(Category category)
        {
            Category catg = this.context.Categories.FirstOrDefault(x => x.ID == category.ID);
            catg.Nmae = category.Nmae;
            catg.Image = category.Image;
            catg.Code = category.Code;
            catg.Description = category.Description;

            return this.context.SaveChanges();
                
        }

        public int Delete(int ID)
        {
            Category catg = this.context.Categories.FirstOrDefault(x => x.ID == ID);
            this.context.Categories.Remove(catg);

            return this.context.SaveChanges();
        }

        public int Insert(Category category)
        {
            this.context.Categories.Add(category);
            return this.context.SaveChanges();
        }
    }
}
