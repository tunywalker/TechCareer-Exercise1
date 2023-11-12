using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Data
{
    public  interface IEntityBase<TEntity>
    {
        void Add(TEntity entityName);
        void Delete(int id);
        List<TEntity> GetAll();
        TEntity? GetById(int id);
    }
}
