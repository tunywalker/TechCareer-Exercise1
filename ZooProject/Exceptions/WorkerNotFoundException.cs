using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Exceptions;

public class WorkerNotFoundException : Exception
{
    public WorkerNotFoundException(string name) : base($"{name} ismine sahip çalışan bulunamadı.")
    {

    }
    public WorkerNotFoundException(int id) : base($"{id} kimlik numarasına sahip çalışan bulunamadı.")
    {

    }
}
