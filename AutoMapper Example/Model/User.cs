using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper_Example.Model;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string Password { get; set; }
    public string? Description { get; set; }
    public string? Username  { get; set; }

    public override string ToString()
    {
        return $"Id : Name :{Name} Username:{Username} Password:{Password} Description: {Description}";
    }

}


