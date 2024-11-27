namespace aspnet_formapp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();
        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Manga" });
            _categories.Add(new Category { CategoryId = 2, Name = "Anime" });
            _products.Add(new Product { ProductId = 1, Name = "Berserk 1. Cilt", Price = 150, IsActive = true, Image = "berserk-1.jpeg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "Naruto 1. Cilt", Price = 135, IsActive = true, Image = "naruto-1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "One Piece 1. Cilt", Price = 120, IsActive = true, Image = "one-piece-1.jpg", CategoryId = 1 });

            _products.Add(new Product { ProductId = 4, Name = "Berserk - Black Swordsman Arc", Price = 300, IsActive = true, Image = "berserk-a1.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 5, Name = "Naruto - Land of Waves Arc", Price = 500, IsActive = true, Image = "naruto-a1.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "One Piece - Romance Dawn Arc", Price = 200, IsActive = true, Image = "one-piece-a1.jpg", CategoryId = 2 });

        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void DeleteProduct(Product toBeDeletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == toBeDeletedProduct.ProductId);

            if (entity != null)
            {
                _products.Remove(entity);
            }
        }
        

        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.IsActive = updatedProduct.IsActive;
            }
        }
    }
}