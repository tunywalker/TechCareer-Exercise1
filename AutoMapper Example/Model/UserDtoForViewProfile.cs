using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper_Example.Model
{
    public  class UserDtoForViewProfile
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public override string ToString()
        {
            return $"Profili Görüntüle -> {Username} : {Name} - {Description}"; 
        }
    }
}
