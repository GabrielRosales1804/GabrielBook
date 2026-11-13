using System.ComponentModel.DataAnnotations;

namespace GabrielBookWeb.Models
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
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the display order of the category.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
