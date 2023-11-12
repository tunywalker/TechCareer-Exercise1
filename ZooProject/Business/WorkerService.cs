using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Data;
using ZooProject.Models;

namespace ZooProject.Business;

public class WorkerService : IWorkerService
{
    private  IWorkerRepository _workerRepository;

   
    WorkerService(IWorkerRepository workerRepository)
    {
        _workerRepository = workerRepository;
    }
   
    public void Add(Worker worker)
    {
        _workerRepository.Add(worker);

    }

    public void Delete(int id)
    {
        try
        {
            _workerRepository.Delete(id);
        }

        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }

    public void GetById(int id)
    {
        try
        {
            _workerRepository.Delete(id);
        }

        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetByName(string name)
    {
        try
        {
            Console.WriteLine(_workerRepository.GetByName(name) ); 
        }
        catch (Exception ex)
        {

            Console.WriteLine( ex.Message);
        }
      
    }

    public void GetList()
    {
        _workerRepository.GetAll();
    }
}
