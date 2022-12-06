Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number>99 ? number.ToString()[2] : '-');
Console.ReadKey(true);

