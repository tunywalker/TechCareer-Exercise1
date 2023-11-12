using Day_4_BookProject.Models;
using Day4_BookProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Data
{
    interface IAuthorRepository : IEntityBaseRepository<Author, int>
    {
        
    }
}
