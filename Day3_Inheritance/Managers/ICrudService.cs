using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Inheritance.Managers;

internal interface ICrudService
{
    public void Add();
    public void Update();
    public void Delete();
    public void GetAll();
}
