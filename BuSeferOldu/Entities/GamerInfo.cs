using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuSeferOldu.Entities
{
    public class GamerInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcN { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
