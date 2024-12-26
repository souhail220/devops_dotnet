using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static List<Product> Products { get; set; } = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Wireless Headphones",
                Category = "Electronics",
                Description = "High-quality wireless headphones with noise cancellation.",
                ImageFile = "wireless_headphones.jpg",
                Price = 99.99m
            },
            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Category = "Electronics",
                Description = "Latest model smartphone with a high-resolution camera.",
                ImageFile = "smartphone.jpg",
                Price = 699.99m
            },
            new Product
            {
                Id = 3,
                Name = "Running Shoes",
                Category = "Sportswear",
                Description = "Comfortable and lightweight running shoes for all terrains.",
                ImageFile = "running_shoes.jpg",
                Price = 59.99m
            },
            new Product
            {
                Id = 4,
                Name = "Coffee Maker",
                Category = "Home Appliances",
                Description = "Brews fresh coffee quickly and efficiently.",
                ImageFile = "coffee_maker.jpg",
                Price = 45.50m
            },
            new Product
            {
                Id = 5,
                Name = "Bluetooth Speaker",
                Category = "Electronics",
                Description = "Portable Bluetooth speaker with superior sound quality.",
                ImageFile = "bluetooth_speaker.jpg",
                Price = 29.99m
            },
            new Product
            {
                Id = 6,
                Name = "Office Chair",
                Category = "Furniture",
                Description = "Ergonomic office chair with lumbar support.",
                ImageFile = "office_chair.jpg",
                Price = 149.99m
            }
        };
    }
}
