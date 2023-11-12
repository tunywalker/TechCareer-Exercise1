using Day_4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Business
{
    public interface IAuthorService
    {
        void GetList();
        void Add(Author author);
        void Delete(int id);
        void GetById(int id);
    }
}
