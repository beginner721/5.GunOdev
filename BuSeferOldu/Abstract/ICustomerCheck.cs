using BuSeferOldu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSeferOldu.Abstract
{
    public interface ICustomerCheck
    {
        bool CheckPerson(GamerInfo gamerInfo);
    }
}
