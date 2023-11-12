using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Cage Cage { get; set; }
    public AnimalType Type { get; set; }
    
}

public enum AnimalType
{
    Cat,
    Dog,
    Elephant,
    Bird,
    Lion
               
}
