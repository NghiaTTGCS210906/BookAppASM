using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace BookAppASM.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [StringLength(50)]

        public string? Name { get; set; }
        [Required]  

        public float Price { get; set; }
    }
}
