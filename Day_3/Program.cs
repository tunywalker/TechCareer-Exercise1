
using Day_3;
using Day_3.Managers;

//Console.WriteLine("Hello, World!");
//Product product = new Product();
//product.SetName("Laptop");
//product.SetPrice(25000);
//Console.WriteLine($"{product.GetName()} -> {product.GetPrice()}");

//Person person = new Person();
//person.Name = "Tuna BABA";
//person.Surname = "KİNQ";
//person.Email = "dedeoglu@gmail.com";
//person.Password = "11223344";
//Console.WriteLine(person.ToString());

Car car = new Car
{
    BrandName = "Bmw",
    Colour = Colour.Red,
    ModelYear = 2015,
    Price = 10000

};
Console.WriteLine(car);
CarManager carManager = new CarManager();
carManager.Add(car);
//Bir sisteme kayıt olduğumuzda veri tabanıında parolalarımız nasıl görünür.
