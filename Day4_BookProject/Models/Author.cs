using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Models
{
    public class Author : EntityBase<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Yazar Id: {Id} Yazar Adı: {Name}";
        }


    }
}
