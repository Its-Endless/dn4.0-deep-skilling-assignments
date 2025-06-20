using System;
using System.Collections.Generic;
using E_commercePlatformSearch;

namespace E_commercePlatformSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop"),
                new Product(2, "Smartphone"),
                new Product(3, "Headphones"),
                new Product(4, "Keyboard"),
                new Product(5, "Monitor")
            };

            // LINEAR SEARCH
            Console.Write("Enter Product ID to search (Linear Search): ");
            int targetId = int.Parse(Console.ReadLine());

            Product result = LinearSearch(products, targetId);

            if (result != null)
                Console.WriteLine($"✅ Product found: {result}");
            else
                Console.WriteLine("❌ Product not found.");

            // BINARY SEARCH
            // Sort the list by ID before binary search
            products.Sort((a, b) => a.Id.CompareTo(b.Id));

            Console.Write("\nEnter Product ID to search (Binary Search): ");
            int binaryTargetId = int.Parse(Console.ReadLine());

            Product binaryResult = BinarySearch(products, binaryTargetId);

            if (binaryResult != null)
                Console.WriteLine($"✅ Product found (Binary Search): {binaryResult}");
            else
                Console.WriteLine("❌ Product not found (Binary Search).");
        }

        // LINEAR SEARCH METHOD
        static Product LinearSearch(List<Product> products, int targetId)
        {
            foreach (var product in products)
            {
                if (product.Id == targetId)
                    return product;
            }
            return null;
        }

        // BINARY SEARCH METHOD
        static Product BinarySearch(List<Product> products, int targetId)
        {
            int left = 0;
            int right = products.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (products[mid].Id == targetId)
                    return products[mid];
                else if (products[mid].Id < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
