// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha34()
{
    Console.WriteLine("____________________");
    Console.WriteLine("Задача 34");
    Random random = new Random();
    int size = random.Next(4, 9);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Количество четных чисел в массиве: " + CountEvenNumbers(numbers));
}

void FillArray(int[] numbers,
               int minValue = 100,
               int maxValue = 999)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("Задан массив из положительных случайных трехзначных чисел: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            count++;
    }
    return count;
}
Zadacha34();


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.
void Zadacha36()
{
    Console.WriteLine("____________________");
    Console.WriteLine("Задача 36");
    Random random = new Random();
    int size = random.Next(4, 9);
    int[] numbers = new int[size];
    FillArray_36(numbers);
    PrintArray_36(numbers);
    Console.WriteLine("Сумма элементов с нечётными индексами: " + SumNotEvenIndex(numbers));
}
void FillArray_36(int[] numbers,
               int minValue = -100,
               int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray_36(int[] numbers)
{
    Console.Write("Задан случайный массив чисел: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

int SumNotEvenIndex(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + numbers[i];
    }
    return sum;
}

Zadacha36();


// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha38()
{
    Console.WriteLine("____________________");
    Console.WriteLine("Задача 38");
    Random random = new Random();
    int size = random.Next(4, 9);
    double[] numbers = new double[size];
    FillArray_38(numbers);
    PrintArray_38(numbers);
    DiffMaxMin(numbers);
}
void FillArray_38(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {

        numbers[i] = Math.Round(random.NextDouble(), 2) + random.Next(-20, 20);

    }
}

void PrintArray_38(double[] numbers)
{
    Console.WriteLine("Задан случайный массив вещественных чисел: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + " ");
    }
    Console.WriteLine();
}

void DiffMaxMin(double[] numbers)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
        if (numbers[i] < min)
            min = numbers[i];
    }
    Console.WriteLine($"Максимальное число массива: {max}");
    Console.WriteLine($"Минимальное число массива: {min}");
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");
}

Zadacha38();

