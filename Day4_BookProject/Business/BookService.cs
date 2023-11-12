
using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Business;

internal class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public void Add(Book book)
    {
        //Validasyon kurallarından geçmeyen kitabı listeye ekleme 
       
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

    public void Delete(int id)
    {
        try
        {
            _bookRepository.Delete(id);
            List<Book> books = _bookRepository.GetAll();
            GetList();
        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
       
    }

    public void GetById(int id)
    {
        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);
        }

        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex);
        }
    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }
    private void AddRules(Book book)
    {

        if(book.Title.Length<2)
        {
            throw new BookTitleException(book.Title);
        }
        if(book.Price <0 || book.Stock<0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }
}
