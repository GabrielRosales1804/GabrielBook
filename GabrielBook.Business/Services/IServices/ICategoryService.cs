using GabrielBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GabrielBook.Business.Services.IServices
{
    public interface ICategoryService
    {
        Task<Category?> GetAllCategoriesByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
    }
}
