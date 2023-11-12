using Day_4_BookProject.Data;
using Day_4_BookProject.Exceptions;
using Day_4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Business;

internal class AuthorService : IAuthorService
{

    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void Add(Author author)
    {
        try
        {
            AddRules(author); 
            _authorRepository.Add(author);
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
            _authorRepository.Delete(id);
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
            Author? author = _authorRepository.GetById(id);
            Console.WriteLine(author);
        }

        catch (Exception ex)
        {

            Console.WriteLine(ex);
        }
    }

    public void GetList()
    {
        _authorRepository.GetAll().ForEach(author => Console.WriteLine(author));
    }

    private void AddRules(Author author)
    {

        if (author.Name.Length < 2)
        {
            throw new AuthorNameException(author.Name);
        }
    }
}
