using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Data;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Business;

public class ZooService : IZooService
{
    private readonly IZooRepository _zooRepository;

    public ZooService(IZooRepository zooRepository)
    {
        _zooRepository = zooRepository;
    }

    public void Add(Zoo zoo)
    {
        try
        {
            AddRules(zoo);
            _zooRepository.Add(zoo);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _zooRepository.Delete(id);

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
            var zoo = _zooRepository.GetById(id);
            Console.WriteLine(_zooRepository.GetById(id));
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
            Console.WriteLine(_zooRepository.GetByName(name));
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        _zooRepository.GetAll().ForEach(x => Console.WriteLine(x));
    }

    private void AddRules(Zoo zoo)
    {
        if (zoo.Name.Length < 3)
            throw new ZooNameException(zoo.Name);

    }
}
