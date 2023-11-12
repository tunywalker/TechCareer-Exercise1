using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Models;

public class Zoo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    public List<Worker>? Workers { get; set; } = new List<Worker>();
    public override string ToString()
    {
        return $"Id:{Id} Name:{Name} Location:{Location} Workers:{Workers.Count}";
    }
}
