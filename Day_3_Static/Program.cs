// See https://aka.ms/new-console-template for more information
using Day_3_Static;


byte[] passwordHash;
byte[] passwordSalt;
Console.WriteLine("Şifrenizi Giriniz:");
string password = Console.ReadLine();
SecurityHelper.CreatePasswordHash(password,out passwordHash, out passwordSalt);
Console.WriteLine($"Şifreniz: {password}");
Console.WriteLine($"Şifreniz Hashi:");
foreach (var hash in passwordHash)
{
    Console.Write(hash);
}
Console.WriteLine();
Console.WriteLine($"Şifrenizin Saltı:");
foreach (var salt in passwordSalt)
{
    Console.Write(salt);
}