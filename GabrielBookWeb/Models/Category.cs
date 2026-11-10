using System.ComponentModel.DataAnnotations;

namespace GabrielBookWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
