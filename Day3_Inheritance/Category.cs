using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Inheritance;

public class Category:EntityBase
{
    public string CategoryName { get; set; }
    public override string ToString()
    {
        return $"Id : {this.Id} Kim Oluşturdu : {this.CreatedBy} Ne Zaman Oluşturdu : {this.CreatedDate} Ad : {this.CategoryName}";
    }
    public void Create()
    {
        Console.WriteLine("Category Eklendi");
    }
}
