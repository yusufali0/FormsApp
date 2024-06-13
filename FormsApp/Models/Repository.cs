namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId=1 ,Name="Telefon"});
            _categories.Add(new Category { CategoryId=2 ,Name="Bilgisayar"});

            _products.Add(new Product { ProductId=1,Name="iPhone 14",Price=40000,IsActive=true,Image="1.jpeg", CategoryId=1 });
            _products.Add(new Product { ProductId=2,Name="iPhone 15",Price=50000,IsActive=true,Image="2.jpeg", CategoryId=1 });
            _products.Add(new Product { ProductId=3,Name="iPhone 16",Price=60000,IsActive=false,Image="3.jpeg", CategoryId=1 });
            _products.Add(new Product { ProductId=4,Name="iPhone 17",Price=70000,IsActive=true,Image="4.jpeg", CategoryId=1 });

            _products.Add(new Product { ProductId=5,Name="Macbook",Price=80000,IsActive=true,Image="5.jpeg", CategoryId=2 });
            _products.Add(new Product { ProductId=6,Name="Imac",Price=75000,IsActive=false,Image="6.jpeg", CategoryId=2 });

        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }


        public static void EditProduct(Product updatedProduct)
        {
            var entity=_products.FirstOrDefault(p=>p.ProductId==updatedProduct.ProductId);

            if (entity != null)
            {
                if (!string.IsNullOrEmpty(entity.Name))
                {
                    entity.Name = updatedProduct.Name;
                }
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
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



        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p=>p.ProductId== deletedProduct.ProductId);

            if(entity != null)
            {
                _products.Remove(entity);
            }
        }


        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}
