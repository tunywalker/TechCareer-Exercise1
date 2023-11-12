using AutoMapper;
using AutoMapper_Example.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper_Example.Services
{
    public  class AutoMapperService
    {
        public IMapper Mapper { get; private set; }

        public AutoMapperService()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDtoForViewProfile>().ReverseMap();
                
            });

            Mapper = config.CreateMapper();
        }


    }
}
