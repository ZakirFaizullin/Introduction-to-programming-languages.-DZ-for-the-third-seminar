// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Reverse(int num)
{
    int result = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;
        result = result * 10;
        result = result + digit;
    }

    return result;
}



Console.WriteLine($"Введите целое пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if (num == Reverse(num))
{
    System.Console.WriteLine($"Это число является палиндромом");
}
else
{
    System.Console.WriteLine($"Это число не является палиндромом");
}
