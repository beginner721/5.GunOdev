using BuSeferOldu.Concrete;
using BuSeferOldu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSeferOldu.Abstract
{
    public interface ISatisManager
    {
        void Sat(GamerInfo gamerInfo, Kampanyalar kampanyalar );
    }
}
