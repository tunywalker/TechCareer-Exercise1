using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Business;

internal interface IBookService
{
    void GetList();
    void Add(Book book);
    void Delete(int id);
    void GetById(int id);
}
