using System.Runtime.Serialization;

namespace Day4_BookProject.Consts;

public class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title} , minimum 2 karakterli olmalıdır. Girdiğiniz karakter sayısı: {title.Length}";
    }

    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"Girdğiniz stok ve değer bilgisi negatif değerler olamaz Stok: {stock}, Kitap değeri: {price}";
    }

    public static string AuthorNotFoundExceptionMessage(int id)
    {
        return $"{id}, ye ait yazar bulunamadı.";
    }
    public static string AuthorNameExceptionMessage(string name)
    {
        return $"Girdiğiniz yazar adı '{name}' minimum 2 karakterli olmalıdır ! Girdiğiniz karakter sayısı: {name.Length}";
    }
}
