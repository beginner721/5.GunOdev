using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuSeferOldu.ServiceReference1;
using BuSeferOldu.Entities;
using BuSeferOldu.Abstract;

namespace BuSeferOldu.Adapter
{
    public class MernisServiceAdapter:ICustomerCheck
    {
        public bool CheckPerson(GamerInfo gamerInfo)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamerInfo.TcN), gamerInfo.FirstName.ToUpper(), gamerInfo.LastName.ToUpper(), gamerInfo.DateOfBirth.Year);
        }
        
    }
}
