using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuSeferOldu.Abstract;
using BuSeferOldu.Concrete;
using BuSeferOldu.Entities;
using BuSeferOldu.Adapter;

namespace BuSeferOldu
{
    class Program
    {
        static void Main(string[] args)
        {


            GamerInfo gamerInfo = new GamerInfo
            {
                FirstName = "Memduh Baran",
                Id = 1,
                LastName = "Kurtboğan",
                TcN = "31265166910",
                DateOfBirth = new DateTime(1997, 5, 21)
            };

            Kampanya Kampanya = new Kampanya();
            Kampanyalar kampanyalar = new Kampanyalar { Kampanya1 = "%50 INDIRIM" };

            Satis satis = new Satis(new MernisServiceAdapter());
            satis.Sat(gamerInfo,kampanyalar);
            Console.ReadLine();

        }
    }
}
