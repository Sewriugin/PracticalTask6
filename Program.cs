// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 41: Пользователь вводит с клавиатуры М чисел.  
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//           1) 0, 7, 8, -2, -2 -> 2; 2) -1, -7, 567, 89, 223 -> 3

// Задача 41
Console.WriteLine("Задача 41");


void inputNumbers(int number, int [] array)
{
    int count = 1;
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите " + count + " " + "число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
}

void printArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void numbersGreaterZero(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    Console.WriteLine("Количество чисел больше 0 => " + count);
}

System.Console.Write("Количество чисел для ввода: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberN];

inputNumbers(numberN, array);
printArray(array);
numbersGreaterZero(array);


// Задача 42: Напишите программу, которая будет преобразовывать    
// десятичное число в двоичное
//           1) 45 -> 101101; 2) 3 -> 11; 3) 2 -> 10

// Задача 42
Console.WriteLine("Задача 42");

void decInBin (int dec)
{
    if (dec >= 1)
    {
        int binDec = dec % 2;
        decInBin(dec / 2);
        Console.Write(binDec);
    }
}

decInBin(45);
Console.WriteLine();

decInBin(3);
Console.WriteLine();

decInBin(2);
Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,   
// заданных уровнениями
//           y = k1 * x + b1
//           y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем
//          b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Задача 43
Console.WriteLine("Задача 43");

void intersectionPoint (double b1, double k1, double b2, double k2)
{
    double x, y;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    if ((k1 * b2 - b1 * k2) == 0)
    Console.WriteLine("Прямые параллельны");
    else
    if ((k1 * k2 - b1 * b2) == 0)
    Console.WriteLine("Прямые перпендикулярны");
    else
    Console.WriteLine("Точка пересечения двух прямых: " + " x = " + x + ", y = " + y);
}

intersectionPoint(b1: 2, k1: 5, b2: 4, k2: 9);


