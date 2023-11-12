using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Models;

internal class Category:EntityBase<string>
{
    public string Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}
