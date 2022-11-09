using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class CustomerDB
    {
        private const string dir = @".\GameStore\GameStore\";
        private const string path = dir + "Customers.txt";

        public static void SaveCustomers(List<Customer> customers)
        {
            StreamWriter customerOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Customer customer in customers)
            {
                customerOut.WriteLine(customer.FirstName + "|" + customer.LastName + "|" + customer.Email);
            }

            customerOut.Close();
        }

        public static List<Customer> GetAllCustomers()
        {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            StreamReader customerIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            List<Customer> customers = new List<Customer>();

            while(customerIn.Peek() != -1)
            {
                string row = customerIn.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.FirstName = columns[0];
                customer.LastName = columns[1];
                customer.Email = columns[2];
                customer.Add(customer);
            }

            customerIn.Close();

            return customers;
        }
    }
}
