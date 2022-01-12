using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Adapters;
using InterfaceAndAbstract.Concrete;
using System;

namespace InterfaceAndAbstract
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1997, 1, 28), FirstName = "Nihat", LastName = "Barlin", NationalityId="21455713390" });
            Console.ReadLine();
        }
    }
}
