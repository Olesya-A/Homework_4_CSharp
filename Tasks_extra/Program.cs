// Задача А. Программа заполняет массив 8 случайными числами. 
// Напишите функцию, которая находит среднее арифметическое чисел в массиве. 


//int[] array = CreateArray(8);
// Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(GetAverage(array));


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

Console.WriteLine(FindMax(array));

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

Console.WriteLine(IsEven(array));