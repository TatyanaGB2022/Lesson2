// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int a = new Random().Next(10, 100);
int b = a / 10;
int c = a % 10;
System.Console.WriteLine($"Наибольшая цифра в числе {a}");
if (b > c)
{
  System.Console.WriteLine($"Больше цифра {b}");
}
  else
  {
    System.Console.WriteLine($"Больше цифра {c}");
  }