using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace GabrielBook.Models
{
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the display order of the category.
        /// </summary>
        [Required]
        [Range(0,100, ErrorMessage = "Range must be  between 0 and 100!!")]
        [Display(Name = "Display Order")]
        //[ValidateNever]
        public int? DisplayOrder { get; set; }
    }
}
