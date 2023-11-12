using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Inheritance;

internal class Product:EntityBase
{

    
    public string Price { get; set; }
   
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {this.Id} Kim Oluşturdu : {this.CreatedBy} Ne Zaman Oluşturdu : {this.CreatedDate} Ad : {this.Name} Fiyat : {this.Price}";
    }
}
