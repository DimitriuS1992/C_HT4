// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < 8; i++)
{
    array[i] = rand.Next(1, 9);
}
Console.WriteLine(string.Join(" ",array));

