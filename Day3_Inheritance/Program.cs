//Product ve Category diye 2 Tane veritabanı Tablosu olduğunu düşnelim tablolar arası basid crud operasyonları
using Day3_Inheritance;
using Day3_Inheritance.Managers;

Category category = new Category()
{
    Id = 1,
    CategoryName = "Bilgisayar",
    CreatedBy = "Fıstık Kinq",
    CreatedDate = "1.1.9999"
};
Product product = new Product()
{
    Id = 3,
    Name = "Asus Hd Kırık",
    Price = "199.000 $",
    CreatedBy = "Paşa Reis",
    CreatedDate = "1.1.9999"
};

Console.WriteLine(category);
Console.WriteLine(product);

ICrudService crudService = new CategoryService();
crudService.Add();
crudService.Delete();
crudService.GetAll();
crudService.Update();
