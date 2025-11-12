namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Models.Product> Products  = new()
        {
            new Models.Product
            {
                Name = "IPhone X",
                Description = "A high-performance laptop for all your computing needs.",
                ImageFile = "iPhone.jpeg",
                Price = 950.00m,
                Category = "Electronics",
            },
            new Models.Product
            {
                Name = "Smartphone",
                Category = "Electronics",
                Description = "A sleek smartphone with the latest features.",
                ImageFile = "SmartPhone.jpeg",
                Price = 699.99m
            },
            new Models.Product
            {
                Name = "Headphones",
                Category = "Accessories",
                Description = "Noise-cancelling headphones for immersive sound.",
                ImageFile = "Headphone.jpeg",
                Price = 199.99m
            },
            new Models.Product
            {
                Name = "Headphones 1",
                Category = "Accessories",
                Description = "Noise-cancelling headphones for immersive sound.",
                ImageFile = "Headphone1.jpeg",
                Price = 199.99m
            },
            new Models.Product
            {
                Name = "Headphones 2",
                Category = "Accessories",
                Description = "Noise-cancelling headphones for immersive sound.",
                ImageFile = "Headphone2.jpeg",
                Price = 199.99m
            },
              new Models.Product
            {
                Name = "Headphones No 3 - new no 3",
                Category = "Accessories",
                Description = "Noise-cancelling headphones for immersive sound.",
                ImageFile = "61qFaIA630L.jpg",
                Price = 199.99m
            }
        };
    }
}
