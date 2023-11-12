using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Models;

namespace ZooProject.Business;

internal interface IWorkerService
{
    void GetList();
    void Add(Worker worker);
    void Delete(int id);
    void GetById(int id);
    void GetByName(string name);
}
