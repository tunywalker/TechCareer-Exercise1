using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>()
            {
            new Category(){ Id="A",Name="Polisiye"},
            new Category() { Id = "B", Name="Aksiyon " },
            new Category() { Id = "C", Name="Macare" }

        };
        }

       
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categories; 
        }

        public Category? GetById(string id)
        {
            Category category= _categories.FirstOrDefault(c => c.Id == id);
            if(category is not null)
                 return category;
            return null;
        }
    }
}
