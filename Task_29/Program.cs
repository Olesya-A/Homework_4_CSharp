//  29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите числа через запятую: ");
string input = Console.ReadLine()!;
string[] numbers = input.Split(',');
int size = numbers.Length;

int[] array = CreateArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(numbers[i]);
    }
    return array;
}