using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Exceptions
{
    public class ZooNotFoundException : Exception
    {
        public ZooNotFoundException(int id):base($"'{id}' sine sahip hayvanat bahçesi bulunamadı. ")
        {
        }
        public ZooNotFoundException(string name) : base($"'{name}' ismine sahip hayvanat bahçesi bulunamadı. ")
        {
        }
    }
}
