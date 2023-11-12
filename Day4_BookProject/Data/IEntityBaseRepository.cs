using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data
{
    public interface IEntityBaseRepository<TEntity, Tid>
    {
        void Add(TEntity category);
        void Delete(Tid id);
        List<TEntity> GetAll();
        TEntity? GetById(Tid id);
    }
}
