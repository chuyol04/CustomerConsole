using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileCustomerDataProvider dataProvider = new FileCustomerDataProvider();

            //Populate the list with at least three customers 
            Customer Client1 = new Customer { Id = 1, Name = "Jesus Cruz", Age  = 24, Email = "chuy_mtz_1999@hotmail.com" };
            Customer Client2 = new Customer { Id = 2, Name = "Edwin Moreno", Age = 24, Email = "edwin@hotmail.com" };
            Customer Client3 = new Customer { Id = 3, Name = "John Gillespie", Age = 31, Email = "Jhon_mtz_1999@hotmail.com" };
            Customer Client4 = new Customer { Id = 4, Name = "Doe", Age = 33, Email = "Felix_mtz_1999@hotmail.com" };

            dataProvider.SaveCustomer(Client1);
            dataProvider.SaveCustomer(Client2);
            dataProvider.SaveCustomer(Client3);
            dataProvider.SaveCustomer(Client4);

            List<Customer> customers = dataProvider.GetCustomerList();

            Console.WriteLine("////////////////////Todos los clientes/////////////////////////");

            //recorre la lista de customer donde guarde los clientes y se almacena en la variable customers, esto es para ver mi lista original.
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Email: {customer.Email}");

            }

            Console.WriteLine("////////////////////CLIENTES MAYOR A 30/////////////////////////");

            var customersmorethan30 = dataProvider.GetCustomerList().Where(customer => customer.Age > 30).ToList();

            foreach(var customer in customersmorethan30)
            {
                Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Email: {customer.Email}");
            }

            Console.WriteLine("////////////////////CLIENTES con nombre DOE/////////////////////////");

            var CustomersNamedDoe = dataProvider.GetCustomerList().Where(customer => customer.Name.Contains("Doe")).ToList();

            foreach (var customer in CustomersNamedDoe)
            {
                Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Email: {customer.Email}");
            }


            //para leer lo que se guardo
            Console.ReadLine();


        }
    }
}
