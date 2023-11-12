using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Models;

public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }


    public List<Cage>? Cages { get; set; } = new List<Cage>();
}
