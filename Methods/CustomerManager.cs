using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id+" ID li"+" "+customer.Name+" "+customer.LastName+" "+"Müşterisi eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " ID li" + " " + customer.Name + " " + customer.LastName + " " + "Müşterisi Silindi");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Id + " ID li" + " " + customer.Name + " " + customer.LastName + " " + "Müşterisi Güncellendi");
        }
    }
}
