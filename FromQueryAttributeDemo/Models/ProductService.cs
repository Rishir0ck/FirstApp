using System;

namespace FromQueryAttributeDemo.Models;

public class ProductService
{
    private readonly List<Product>? _products;

    public ProductService()
    {
        _products = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone 12", Category = ProductCategory.Electronics, Price = 799.99m, DateAdded = new DateTime(2020, 10, 13) },
            new Product { Id = 2, Name = "MacBook Pro", Category = ProductCategory.Computers, Price = 1299.99m, DateAdded = new DateTime(2020, 11, 10) },
            new Product { Id = 3, Name = "Apple Watch", Category = ProductCategory.Wearables, Price = 399.99m, DateAdded = new DateTime(2020, 9, 15) },
            new Product { Id = 4, Name = "Sony WH-1000XM4", Category = ProductCategory.Audio, Price = 349.99m, DateAdded = new DateTime(2020, 8, 6) },
            new Product { Id = 5, Name = "Canon EOS R6", Category = ProductCategory.Cameras, Price = 2499.99m, DateAdded = new DateTime(2020, 7, 30) },
            new Product { Id = 6, Name = "PlayStation 5", Category = ProductCategory.Gaming, Price = 499.99m, DateAdded = new DateTime(2020, 11, 12) },
            new Product { Id = 7, Name = "Xbox Series X", Category = ProductCategory.Gaming, Price = 499.99m, DateAdded = new DateTime(2020, 11, 10) },
            new Product { Id = 8, Name = "Samsung Galaxy Buds Pro", Category = ProductCategory.Audio, Price = 199.99m, DateAdded = new DateTime(2020, 12, 15) },
            new Product { Id = 9, Name = "Dyson V11", Category = ProductCategory.HomeAppliances, Price = 599.99m, DateAdded = new DateTime(2020, 10, 20) },
            new Product { Id = 10, Name = "Amazon Echo Dot", Category = ProductCategory.SamrtHome, Price = 49.99m, DateAdded = new DateTime(2020, 11, 30)}
        };

    }

    public async Task<(IEnumerable<Product> products, int TotalCount)> GetProductsAsync(ProductQueryParameters queryParameters)
    {
        var products = _products.AsQueryable();

        if (!string.IsNullOrEmpty(queryParameters.SearchTerm))
        {
            products = products.Where(p => p.Name.Contains(queryParameters.SearchTerm, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrEmpty(queryParameters.Category))
        {
            if (Enum.TryParse<ProductCategory>(queryParameters.Category, out var category))
            {
                products = products.Where(p => p.Category == category);
            }
        }

        int totalCount = products.Count();

        if (!string.IsNullOrEmpty(queryParameters.SortBy))
        {
            if (queryParameters.SortBy.Equals("price", StringComparison.OrdinalIgnoreCase))
            {
                products = queryParameters.SortAscending ? products.OrderBy(p => p.Price) : products.OrderByDescending(p => p.Price);
            }
            else if (queryParameters.SortBy.Equals("dateAdded", StringComparison.OrdinalIgnoreCase))
            {
                products = queryParameters.SortAscending ? products.OrderBy(p => p.DateAdded) : products.OrderByDescending(p => p.DateAdded);
            }

        }
        products = products.Skip((queryParameters.PageNumber - 1) * (queryParameters.PageSize)).Take(queryParameters.PageSize);

        return await Task.FromResult((products, totalCount));

    }





}
