// Напишите функцию и запустите ее, которая принимает на вход число
// и выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ(int n)
{
    int i = 0;

    while (n > 0)
    {
        i = i + (n % 10);
        n = n / 10;
    }
    return i;
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {N} равна {Summ(N)}.");
