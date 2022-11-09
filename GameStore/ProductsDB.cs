using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class ProductsDB
    {
        private const string dir = @".\GameStore\GameStore\";
        private const string path = dir + "Products.txt";

        public static void SaveProducts(List<Product> products)
        {
            StreamWriter productOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Product product in products)
            {
                productOut.WriteLine(product.Code + "|" + product.Name + "|" + product.Price);
            }

            productOut.Close();
        }

        public static List<Product> GetAllProducts()
        {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            StreamReader productIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Product> products = new List<Product>();

            while (productIn.Peek() != -1)
            {
                string row = productIn.ReadLine();
                string[] columns = row.Split('|');
                Product product = new Product();
                product.Code = columns[0];
                product.Name = columns[1];
                product.Price = columns[2];
                product.Add(product);
            }

            productIn.Close();

            return products;
        }

    }
}
