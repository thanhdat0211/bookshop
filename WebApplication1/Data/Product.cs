using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    [Table("Product")]

    public partial class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public string Information { get; set; }
    }
}
