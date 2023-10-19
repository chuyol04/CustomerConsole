using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole
{
    public class FileCustomerDataProvider : ICostumerDataProvider
    {
        //instanciamos la clase para almacenar objetos y utilizarla 
        private List<Customer> _CustomerList = new List<Customer>();

        public List<Customer> GetCustomerList()
        {
            return _CustomerList;
           
        }

        public List<Customer> GetCustomerListByAgeRange(int minAge, int maxAge)
        {
            return _CustomerList.Where(customer => customer.Age >= minAge && customer.Age <= maxAge).ToList();
        }

        public void SaveCustomer(Customer customer)
        {
            _CustomerList.Add(customer);
        }

        public void SaveCustomerList(List<Customer> customers)
        {
            _CustomerList.AddRange(customers);
        }
    }
}
