using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category> {
                new Category
                {
                    CategoryId=1,
                    CategoryName="Programalama Dili",
                    CategoryDescription="Backend Programlama Dili"
                },
                new Category
                {
                    CategoryId=2,
                    CategoryName="Data Base",
                    CategoryDescription="Veri Tabanı"
                },
                new Category
                {
                    CategoryId=3,
                    CategoryName="HTML, CSS, Bootstrap",
                    CategoryDescription="İşaretleme Dili ve Kütüphane uygulamaları"
                }
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Update(Category category)
        {
            _categories.Where(c => c.CategoryId == category.CategoryId).ToList().ForEach(c => c = category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(_categories.Find(c => c.CategoryId == category.CategoryId));
        }

        public Category GetById(int id)
        {
            return _categories.Find(c => c.CategoryId == id);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}
