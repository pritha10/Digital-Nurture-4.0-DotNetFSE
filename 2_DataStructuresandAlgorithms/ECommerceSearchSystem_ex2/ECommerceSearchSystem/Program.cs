using System;

namespace ECommerceSearchSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Mobile", "Electronics"),
                new Product(3, "Shoes", "Fashion"),
                new Product(4, "Watch", "Accessories"),
                new Product(5, "Bag", "Fashion"),
            };

            
            Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

            Console.WriteLine("Enter product name to search:");
            string searchName = Console.ReadLine();

           
            Product linearResult = SearchAlgorithms.LinearSearch(products, searchName);
            if (linearResult != null)
                Console.WriteLine($"Linear Search: Found {linearResult.ProductName} in {linearResult.Category}");
            else
                Console.WriteLine("Linear Search: Product not found");

           
            Product binaryResult = SearchAlgorithms.BinarySearch(products, searchName);
            if (binaryResult != null)
                Console.WriteLine($"Binary Search: Found {binaryResult.ProductName} in {binaryResult.Category}");
            else
                Console.WriteLine("Binary Search: Product not found");
        }
    }
}
