// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int deg = 1;
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    deg *= a;
}
Console.WriteLine(deg);