using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Abstract
{

    public abstract class BaseCustomerManager : ICustomerService
    {
        /*Abstract: bir sınıf üzerinde bulunan özellikleri kullanarak yeni bir sınıf türetmek istediğimiz zaman, içerisinde bulunan
         *bazı temel yapıları yeniden oluşturmak için override (aşırı yükleme) işlemini uygular ve sınıf yapılarına göre özel bir hale getiririz. */

        /* Virtual olarak belirtilen metot yapıları kalıtım yolu ile aktarıldıkları sınıfların içerisinde override edilerek değiştirilebilirler.
         * Eğer override işlemi uygulanmazsa üst sınıf içerisindeki yapısını koruyarak çalışmaya devam eder. */
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
