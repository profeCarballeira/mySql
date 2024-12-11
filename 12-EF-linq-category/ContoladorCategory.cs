using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using _12_EF_linq_category.Modelss;

namespace _12_EF_linq_category
{
    public class CategoryController
    {
        private w3schoolsContext _context;

        public CategoryController()
        {
            _context = new w3schoolsContext();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            var existingCategory = _context.Categories.Find(category.CategoryId);
            if (existingCategory != null)
            {
                // Mapear las propiedades actualizadas aquí
                existingCategory.CategoryName = category.CategoryName;
                existingCategory.Description = category.Description;
                _context.SaveChanges();
            }
        }

        public void DeleteCategory(int CategoryId)
        {
            var category = _context.Categories.Find(CategoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
