using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Data
{
    internal class WorkerRepository : IWorkerRepository
    {
        List<Worker> _workers = new List<Worker>();

        public WorkerRepository()
        {
            _workers = new List<Worker>()
            {
                new Worker(){ Id=1,Name="Tuna",Salary=1000},
                new Worker(){ Id=2,Name="Micheal Jackson",Salary=589},
                new Worker(){ Id=3,Name="Crocodile Dundee",Salary=1999},

            };
        }

        public Exception WorkerNotFoundException { get; private set; }

        public void Add(Worker worker)
        {
            _workers.Add(worker); 
        }

        public void Delete(int id)
        {
           
            var worker = _workers.FirstOrDefault(x => x.Id == id);
            if (worker is not null)
                _workers.Remove(worker);
            else
                throw new WorkerNotFoundException(id);

        }

        public List<Worker> GetAll()
        {
            return _workers;
        }

        public Worker? GetById(int id)
        {
            var worker = _workers.FirstOrDefault(x => x.Id == id);
            if (worker is not null)
                return worker;
            else
                throw new WorkerNotFoundException(id);
        }

        public Worker GetByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
