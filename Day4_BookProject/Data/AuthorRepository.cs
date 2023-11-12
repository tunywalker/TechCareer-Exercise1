using Day_4_BookProject.Exceptions;
using Day_4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Data
{
    public class AuthorRepository : IAuthorRepository
    {

        private List<Author> _authorData;

        public AuthorRepository()
        {
            _authorData = new List<Author>
        {
            new Author { Id = 1, Name = "Tuna", },
            new Author { Id = 2, Name = "Mehmet" },
            new Author { Id = 3, Name = "Ayşe" },
            new Author { Id = 4, Name = "Fatma" },
            new Author { Id = 5, Name = "Mustafa" },
            new Author { Id = 6, Name = "Emine" },
            new Author { Id = 7, Name = "Osman" },
            new Author { Id = 8, Name = "Zeynep" },
            new Author { Id = 9, Name = "Merve" },
            new Author { Id = 10, Name = "Hüseyin" }
        };
        }
        public void Add(Author  author)
        {
            _authorData.Add(author);

        }

        public void Delete(int id)
        {
            var author = _authorData.Where(x => x.Id == id).SingleOrDefault();
            if (author is null)
                throw new AuthorNotFoundException(id);
            _authorData.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _authorData;
        }

        public Author? GetById(int id)
        {
        
            Author? author = _authorData.SingleOrDefault(x => x.Id == id);
            if (author is null)
                throw new AuthorNotFoundException(id);
            return author;
        }
    }
}
