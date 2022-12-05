Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int firstPart = number/10;
int secondPart = firstPart%10;
Console.WriteLine(secondPart);
