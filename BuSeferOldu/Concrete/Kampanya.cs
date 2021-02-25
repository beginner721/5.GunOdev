using BuSeferOldu.Abstract;
using BuSeferOldu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSeferOldu.Concrete
{
    public class Kampanya : IKampanyaManager
    {
        public void Add(Kampanyalar kampanyalar)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Kampanyalar kampanyalar)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Kampanyalar kampanyalar)
        {
            Console.WriteLine("Kampanya Eklendi");
        }
    }
}
