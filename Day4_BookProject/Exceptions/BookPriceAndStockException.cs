using Day4_BookProject.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions;

internal class BookPriceAndStockException:Exception
{
    public BookPriceAndStockException(double price, int stock) :base(Messages.BookPriceAndStockExceptionMessage(price,stock))
    {

    }

}
