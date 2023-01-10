using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopProductListLab.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayName("Product Description")]
        public string Description { get; set; }
        
        [DisplayName("Product Price")]
        public double Price { get; set; }

        [MaxLength(20)]
        [DisplayName("Product Category")]
        public string Category { get; set; }
    }
}
