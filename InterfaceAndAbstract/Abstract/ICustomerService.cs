using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Abstract
{
    public interface ICustomerService
    {
        /*C# Interface, yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan, kendisinden implement edilen bir sınıfa
          doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır. */
        // her iki müşteri tipinde geçerli olan metotlar Interface olarak eklenmeli (soyutlanmalı).
        // bu örnekde Save() fonksiyonu ortak bu sebeple interface olarak eklendi.
        // Interface implementasyonu (eklemek uygulamak) yapan her class bu Save() operasyonunu kullanmak zorunda.

        void Save(Customer customer);
    }
}
