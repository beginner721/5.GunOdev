using BuSeferOldu.Abstract;
using BuSeferOldu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSeferOldu.Concrete
{
    public class Satis : ISatisManager
    {
        ICustomerCheck customerCheck;

        public Satis(ICustomerCheck customerCheck)
        {
            this.customerCheck = customerCheck;
        }

        public void Sat(GamerInfo gamerInfo, Kampanyalar kampanyalar)
        {
            if (customerCheck.CheckPerson(gamerInfo))
            {
                Console.WriteLine(gamerInfo.FirstName + ", Tebrikler. Satın aldınız. " + kampanyalar.Kampanya1 + " Kampanya indirimi uygulandı.");
            }
            else
            {
                throw new Exception("HATA");
            }
        }

 
    }
}
