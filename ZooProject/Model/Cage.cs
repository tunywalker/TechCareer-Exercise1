using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Models;

public class Cage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Animal> Animals { get; set; }
}
