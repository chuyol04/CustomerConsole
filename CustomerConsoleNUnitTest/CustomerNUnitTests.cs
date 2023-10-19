using CustomerConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsoleNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        /*
        [Test]
        public void ClientesMayorA30_ObtenerMayores()
        {
            // Arrange INSTANCIAR OBJETOS
            var customerProvider = new FileCustomerDataProvider();
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Jesus", Age = 24, Email = "test@hotmail.com" },
                new Customer { Id = 2, Name = "Edwin", Age = 31, Email = "test1@hotmail.com" },
                new Customer { Id = 3, Name = "John", Age = 29, Email = "test2@hotmail.com" }
            };

            // Act LLAMAR A METODOS
            var result = customerProvider.GetCustomerListByAgeRange(31, int.MaxValue);

            
             // Assert EVALUAR ESCENARIO
            foreach (var customer in result)
            {
                Assert.IsTrue(customer.Age > 30);
            }
        }
        */

        [Test]
        public void SaveCustomer_AddsCustomerToList()
        {
            // Arrange
            var customerProvider = new FileCustomerDataProvider();
            var customer = new Customer { Id = 1, Name = "Customer1", Age = 25, Email = "customer1@example.com" };

            // Act
            customerProvider.SaveCustomer(customer);
            var result = customerProvider.GetCustomerList();

            // Assert
            CollectionAssert.Contains(result, customer);
        }

    }
}
