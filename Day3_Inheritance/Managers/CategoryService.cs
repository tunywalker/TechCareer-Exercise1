using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Inheritance.Managers
{
    internal class CategoryService : ICrudService
    {
        public void Add()
        {
            Console.WriteLine("Kategori eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kategori silindi.");
        }

        public void GetAll()
        {
            Console.WriteLine("Kategoriler listelendi");
        }

        public void Update()
        {
            Console.WriteLine("Kategori güncelendi.");
        }
    }
}
