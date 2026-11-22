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
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Gets or sets the display order of the category.
        /// </summary>
        [Range(0,100, ErrorMessage = "Range must be  between 0 and 100!!")]
        public int? DisplayOrder { get; set; }
    }
}
