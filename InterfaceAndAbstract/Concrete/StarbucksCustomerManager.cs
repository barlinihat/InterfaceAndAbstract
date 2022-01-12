using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        /*C# Override, oluşturmuş olduğumuz sınıf yapılarında kalıtım sayesinde üst sınıftan, alt sınıfa geçiş sağlayacak metot yapılarının aktarıldığı alt sınıf yapısına
          uygun bir şekilde gövdesinin değiştirilmesine ve kod satırlarının yeniden şekil almasına imkan sağlayan yapıya override denmektedir. */

        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            else
            {
                throw new Exception("Not a valid person");
            }

        }
    }
}
