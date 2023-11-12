using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Models;

namespace ZooProject.Data
{
    public interface IZooRepository:IEntityBase<Zoo>
    {
        public Zoo GetByName(string name);
    }
}
