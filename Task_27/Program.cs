// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumOfDigits(number));

int SumOfDigits(int N)
{
    int sum = 0;
    while (N > 0)
    {
        int digit = N % 10;
        sum = sum + digit;
        N = N / 10;
    }
    return sum;
}