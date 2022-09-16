// ЗАДАЧА А. Программа заполняет массив 8 случайными числами. 
// Напишите функцию, которая находит среднее арифметическое чисел в массиве. 


int[] array = CreateArray(8);
Console.WriteLine($"[{string.Join(", ", array)}]");
// int[] array = {2,4,6,8,6}; //  заданный массив для проверки методов
Console.WriteLine($"Среднее арифметическое массива = {GetAverage(array)}");


int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

double GetAverage(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    double result = sum / array.Length;
    return result;
}

// Задача Б. Программа заполняет массив 8 случайными числами. 
// Напишите функцию, которая принимает массив и находит в нём наибольший элемент. 
// Используйте накопительную переменную. Эта переменная изначально равна первому элементу массива; 
// когда встречается лучший кандидат на максимум, она его запоминает.

Console.WriteLine($"Наибольший элемент массива = {FindMax(array)}");

int FindMax(int[] array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

// Задача В. Программа заполняет массив 8 случайными числами. 
// Напишите функцию, которая проверяет, верно ли, что все числа в массиве чётные. 
// Наличие хотя бы одного нечётного числа означает, что ответ — нет.

bool IsEven(int[] array)
{
    bool check = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 != 0) check = false;
    }
    return check;
}

bool checker1 = IsEven(array);
string answer1 = string.Empty;
if (checker1 == true) answer1 = "да";
else answer1 = "нет";

Console.WriteLine($"Числа в массиве чётные? - {answer1}");

//Console.WriteLine($"Числа в массиве чётные? - {IsEven(array)}"); // true or false

// Задача Г. Программа заполняет массив 8 случайными числами. 
// Напишите функцию, которая проверяет, верно ли, что числа в массиве идут по возрастанию. 
// Если очередное число меньше предыдущего, ответ — нет.

bool IsAscending(int[] array)
{
    bool check = true;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i+1] < array[i]) check = false;
    }
    return check;
}

bool checker2 = IsAscending(array);
string answer2 = string.Empty;
if (checker2 == true) answer2 = "да";
else answer2 = "нет";

Console.WriteLine($"Числа в массиве идут по возрастанию? - {answer2}");

// Console.WriteLine($"Числа в массиве идут по возрастанию? - {IsAscending(array)}"); // true or false