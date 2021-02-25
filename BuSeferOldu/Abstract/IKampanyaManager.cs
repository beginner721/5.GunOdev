using BuSeferOldu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSeferOldu.Abstract
{
    public interface IKampanyaManager
    {
        void Add(Kampanyalar kampanyalar);
        void Delete(Kampanyalar kampanyalar);
        void Update(Kampanyalar kampanyalar);

    }
}
