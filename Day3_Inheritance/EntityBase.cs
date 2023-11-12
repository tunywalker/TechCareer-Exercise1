using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Inheritance;

public abstract class EntityBase
{
    public int Id { get; set; }
    public string CreatedDate { get; set; }
    public string CreatedBy { get; set; }
}
