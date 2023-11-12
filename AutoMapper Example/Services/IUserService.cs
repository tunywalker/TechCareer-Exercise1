using AutoMapper_Example.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper_Example.Services
{
    internal interface IUserService
    {
        public void GetById(int id);
    }
}
