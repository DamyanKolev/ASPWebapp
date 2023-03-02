

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VehicleRental.Models
{
    public enum ProductType
    {
        PC,
        Laptop,
        Smartphone,
        GraphicCard
    }

    public class Product
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30, ErrorMessage = "Product name must be 30 characters or less")]
        [Required]
        public string? ProductName { get; set; }

        [Required]
        public ProductType ProductType { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

    }
}