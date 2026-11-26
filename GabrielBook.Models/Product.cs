using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace GabrielBook.Models
{
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [Required]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the International Standard Book Number for the product.
        /// </summary>
        [Required]
        public string ISBN { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the author of the product.
        /// </summary>
        [Required]
        public string Author { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        [Required]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
        /// <summary>
        /// Gets or sets the price for 1-50 items.
        /// </summary>
        [Required]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        [Display(Name = "Price for 1-50")]
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the price for orders of 50 or more units.
        /// </summary>
        [Required]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        [Display(Name = "Price for 50+")]
        public decimal Price50 { get; set; }
        /// <summary>
        /// Gets or sets the price for orders of 100 or more units.
        /// </summary>
        [Required]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        [Display(Name = "Price for 100+")]
        public decimal Price100 { get; set; }
        /// <summary>
        /// Gets or sets the URL for the product image.
        /// </summary>
        [ValidateNever]
        [Display(Name = "Product Image")]
        public string? ImageUrl { get; set; }
    }
}
