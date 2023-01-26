// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// System.Console.WriteLine("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a > 99 && a < 1000)
// {
//   int result = a % 10;
//   System.Console.WriteLine("Последняя цифра числа равна " + result);
// }
// else 
// {
//   System.Console.WriteLine("Число не трехзначное ");
// }
//  следующий вариант лучше

int InputInt(string massage)
{
  System.Console.WriteLine(massage);
  int x = Convert.ToInt32(Console.ReadLine());
  return x;
}
int a = InputInt("Введите трехзначное число ");
if (a > 99 && a < 1000)
{
  int result = a % 10;
  System.Console.WriteLine("Последняя цифра числа равна " + result);
}
else
{
  System.Console.WriteLine("Число не трехзначное ");
}