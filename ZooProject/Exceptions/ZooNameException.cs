using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Exceptions;

public class ZooNameException : Exception
{
    public ZooNameException(string name) : base($"Hayvanat bahçesi ismi 3 karakterden kısa olamaz. Girdiğiniz karakter sayısı {name.Length}")
    {
    }
}
