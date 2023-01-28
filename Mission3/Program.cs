// Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int InputInt(string massage)
{
  System.Console.WriteLine(massage);
  int x = Convert.ToInt32(Console.ReadLine());
  return x;
}
int a = InputInt("Введите число 1: ");
int b = InputInt("Введите число 2: ");
if (a % b == 0)
System.Console.WriteLine("Да, кратное");
else
{
  System.Console.WriteLine("Нет, не кратно, остаток " + a % b);
}