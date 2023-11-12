using Day4_BookProject.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Exceptions
{
    public class AuthorNotFoundException :Exception
    {
        public AuthorNotFoundException(int id) : base(Messages.AuthorNotFoundExceptionMessage(id))
        {

        }

    }
}
