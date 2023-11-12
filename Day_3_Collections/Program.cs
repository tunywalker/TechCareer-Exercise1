



/*List<int> numbers = new List<int >{1,2,3,4,5,6,7,9,10};
List<int> OddNumbers = new List<int> { };
List<int> EvenNumbers = new List<int> { };
numbers.Add(11);
numbers.Add(12);
numbers.AddRange(new int[] {25,26,27,28,30});
//1. Yöntem
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
//2. Yöntem 
numbers.ForEach(x => Console.WriteLine(x));

Console.WriteLine($"numbers dizisi içerisinde 30 var mı? : {numbers.Contains(30)}");
Console.WriteLine($"numbers dizisi içerisinde 30 Indexi nedir? : {numbers.IndexOf(30)}");
Console.WriteLine($"numbers listesi kaç elemanlıdır? : {numbers.Count}");

// iki listem olacak numbers listesi içerisindeki tek ve çift sayıları ayıracak ve bunları ekrana bastıracak
numbers.ForEach(x => (x % 2 == 0 ? EvenNumbers : OddNumbers).Add(x));

Console.WriteLine("Tek Sayılar:");
OddNumbers.ForEach(x => Console.WriteLine(x));
Console.WriteLine("Çift Sayılar:");
EvenNumbers.ForEach(x => Console.WriteLine(x));*/

