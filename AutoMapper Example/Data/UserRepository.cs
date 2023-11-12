using AutoMapper_Example.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper_Example.Data
{
    public class UserRepository : IEntityBaseRepository<User, int>
    {
        private List<User> _userData;
        User user = new User();
        public UserRepository()
        {
            _userData = new List<User>() {

                new User() { Id = 1, Username = "Tunagl", Password = "114477sifre", Name = "Tuna GÜL", Description = "Güzel bir gün." }
                 };
        }

        public User? GetById(int id)
        {

            User? user = _userData.SingleOrDefault(x => x.Id == id);
            if (user is null)
                throw new Exception();
            return user;
                          
        }
    }
}
