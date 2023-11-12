using AutoMapper;
using AutoMapper_Example.Data;
using AutoMapper_Example.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper_Example.Services
{
    public  class UserService:IUserService
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;


        public UserService(UserRepository userRepository, AutoMapperService autoMapperService)
        {
            _userRepository = userRepository;
            _mapper = autoMapperService.Mapper;
        }

        public void GetById(int id)
        {
            try
            {
                Console.WriteLine(_userRepository.GetById(id));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            }

        public void ViewProfile(int id)
        {
            User user = _userRepository.GetById(id);
            var userDto = _mapper.Map<UserDtoForViewProfile>(user);
            Console.WriteLine(userDto);
        }
    }
}
