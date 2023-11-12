using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3;

public class Person
{
    private string password;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password
    {
        get => password;
        set => password=value+"123abc.";
    }
    public override string ToString()
    {
        return $"İsim : {Name}, Soyisim : {Surname}, Email : {Email}, Password: {Password}";
    }
}
