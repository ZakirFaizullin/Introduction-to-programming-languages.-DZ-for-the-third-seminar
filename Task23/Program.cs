// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cubes(int N)
{
    int result = 0;
    for (int i = 1; i <= N; i++)
    {
        result = i * i * i;
        Console.Write($"{result}, ");
    }
}



System.Console.WriteLine($"Введите число N:");
int N = int.Parse(Console.ReadLine()!);
Cubes(N);