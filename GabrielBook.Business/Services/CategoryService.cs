using GabrielBook.Business.Services.IServices;
using GabrielBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GabrielBook.Business.Services
{
    public class CategoryService : ICategoryService
    {
        public Task CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetAllCategoriesByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
