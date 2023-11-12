//Kitap ekleme listeleme ve silme gibi operasyonları simüle edeceğiz.
//veritabanı gibi çalışan bir liste klanacağız.
using Day_4_BookProject.Business;
using Day_4_BookProject.Data;
using Day_4_BookProject.Models;
using Day4_BookProject.Business;
using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;


IBookService bookService = new BookService(new BookRepository());
////bookService.GetList();
//Book kitap = new Book()
//{
//    Id = 5,
//    Description="k",
//    Price=-1,
//    Stock=100,
//    Title="Kedi ve Fareler"
//};


//Console.WriteLine("-----------------------------------------");
//bookService.Add(kitap);
IAuthorService authorService = new AuthorService(new AuthorRepository());




authorService.Delete(1);
authorService.Add(new Author() {Id=97 ,Name="H" });
authorService.Add(new Author(){ Id = 98, Name = "Halit Ziya" });
authorService.GetList();
Console.WriteLine("------");
authorService.GetById(3);

