using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMug.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Name { get; set; }

        public int Number { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? Description { get; set; }

        public decimal? Price { get; set; }

    }
}
