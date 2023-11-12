using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Data;

public class ZooRepository : IZooRepository
{
    private List<Zoo> _zooData;
    public ZooRepository()
    {
        _zooData = new List<Zoo>()
            {
            new Zoo{Id=1,Name="Darıca Hayvanat Bahçesi",Location="Darıca/Gebze"},
            new Zoo{Id=2,Name="İzmir Hayvanat Bahçesi",Location="Alsancak/İzmir"},
            new Zoo{Id=3,Name=" Hayvanat Bahçesi",Location="Darıca/Gebze"},


            };
            
    }

    public void Add(Zoo zoo)
    {
        _zooData.Add(zoo);
    }

    public void Delete(int id)
    {
       var zoo =_zooData.Where(x=> x.Id ==id).SingleOrDefault();
        if (zoo != null)
            _zooData.Remove(zoo);
        else
            throw new ZooNotFoundException(id);

    }

    public List<Zoo> GetAll()
    {
        return _zooData;
    }

    public Zoo? GetById(int id)
    {
        var zoo = _zooData.Where(x => x.Id == id).SingleOrDefault();
        if (zoo != null)
            return zoo;
        else
            throw new ZooNotFoundException(id);
    }

    public Zoo GetByName(string name)
    {
        var zoo = _zooData.Where(x => x.Name == name).SingleOrDefault();
        if (zoo != null)
            return zoo;
        else
            throw new ZooNotFoundException(name);
        
    }
}
