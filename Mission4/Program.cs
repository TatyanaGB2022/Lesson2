// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int InputInt(string massage)
{
  System.Console.WriteLine(massage);
  int x = Convert.ToInt32(Console.ReadLine());
  return x;
}
int a = InputInt("Введите число : ");
if (a % 7 == 0 && a % 23 == 0)
System.Console.WriteLine("Да, кратное");
else
{
  System.Console.WriteLine("Нет, не кратное");
}