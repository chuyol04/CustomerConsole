using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole
{
    //interfaz con sus metodos.
    public interface ICostumerDataProvider
    {
        List<Customer> GetCustomerList();
        //List<Customer> GetCustomerListByAgeRange(int minAge, int maxAge); // rango de edades solcitado en el punto 3
        void SaveCustomer(Customer customer);
        void SaveCustomerList(List<Customer> customers);
    }
}
