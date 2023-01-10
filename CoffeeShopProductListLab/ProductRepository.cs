using System.Reflection;

namespace CoffeeShopProductListLab.Models
{
    public class ProductRepository
    {
        private List<ProductViewModel> _products;

        public ProductRepository()
        {
            CreateProductList();
        }

        private void CreateProductList()
        {
            _products = new List<ProductViewModel>();
            _products.Add(new ProductViewModel { Id = 1, Name = "Cups", Description = "Package of 500 styrofoam cups for coffee", Category = "Styrofoam", Price = 13.49 });
            _products.Add(new ProductViewModel { Id = 2, Name = "Stir Sticks", Description = "Box of 1,000 coffee stir sticks", Category = "Utensils", Price = 3.99 });
            _products.Add(new ProductViewModel { Id = 3, Name = "Plates", Description = "Bundle of 100 styrofoam plates used to serve muffins and coffee sandwiches", Category = "Styrofoam", Price = 9.49 });
            _products.Add(new ProductViewModel { Id = 4, Name = "Spoons", Description = "Box of 50 plastic spoons", Category = "Utensils", Price = 4.99 });
            _products.Add(new ProductViewModel { Id = 5, Name = "Dark Roast Coffee", Description = "5 pounds of dark roast coffee grounds", Category = "Coffee", Price = 25.88 });
            _products.Add(new ProductViewModel { Id = 6, Name = "Vanilla Coffee", Description = "3 pounds of vanilla flavored coffee grounds", Category = "Coffee", Price = 14.26 });
            _products.Add(new ProductViewModel { Id = 7, Name = "Caramel Coffee", Description = "20 pound box of specialized caramel coffee grounds", Category = "Coffee", Price = 45.19 });
            _products.Add(new ProductViewModel { Id = 8, Name = "Tin Foil", Description = "Bpx of tin foil", Category = "Other", Price = 4.65 });
            _products.Add(new ProductViewModel { Id = 9, Name = "Placemats", Description = "Bpx of 1,000 place mats", Category = "Other", Price = 14.65 });
            _products.Add(new ProductViewModel { Id = 10, Name = "Coke", Description = "Can of Coca Cola for non-cofee drinkers", Category = "Soda", Price = 1.49 });
            _products.Add(new ProductViewModel { Id = 11, Name = "Sprite", Description = "Can of Sprite for non-cofee drinkers", Category = "Soda", Price = 1.49 });
        }

        public IEnumerable<ProductViewModel> GetProducts()
        {
            return _products;
        }
    }
}
