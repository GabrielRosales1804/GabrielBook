using GabrielBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GabrielBook.Business.Services.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category?> GetAllCategoriesByIdAsync(int id);
        Task<Category> CreateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(Category category);
    }
}
