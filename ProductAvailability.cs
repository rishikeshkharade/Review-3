using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    internal class ProductAvailability
    {
        public static void Availability()
        {
            Product product = new Product("Water Bottle", 0);

            Console.WriteLine("Product: "+product.Name);
            Console.WriteLine("Availabe Stock "+product.Stock);

            Console.WriteLine("Enter the quantity you want to purchase: ");
            string input = Console.ReadLine();

            try
            {
                int quantityToPurchase = int.Parse(input);
                product.Purchase(quantityToPurchase);
                Console.WriteLine("You bought" + product.Stock + product.Name);
            }
            catch (ProductOutOfStocKException pe)
            {
                Console.WriteLine(pe.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
        }

    public class Product
    {
        public string Name { get; private set; }
        public int Stock {  get; private set; }
        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public void Purchase(int quantity)
        {
            if (Stock <= 0)
                throw new ProductOutOfStocKException("This product is out of stock.");
            
            if (quantity > Stock) 
                throw new ProductOutOfStocKException("Not enough stock");
            
            Stock -= quantity;
        }
   }

    public class ProductOutOfStocKException : Exception {
        public ProductOutOfStocKException(string message) : base(message) { }
    }
}

