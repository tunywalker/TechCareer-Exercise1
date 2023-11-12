using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Models;

namespace ZooProject.Data;

internal interface IWorkerRepository:IEntityBase<Worker>
{
    public Worker GetByName(string Name);
}
