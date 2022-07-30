// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int size = InputInt("Введите размер массива: ");
double[] numbers = new double[size];
double maxNum = numbers[0], minNum = numbers[1];

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (maxNum < numbers[i])
        maxNum = numbers[i];
    else if (minNum > numbers[i])
        minNum = numbers[i];
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {maxNum - minNum}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)
{
    double a = 0, b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        a = new Random().Next(-100, 100);
        b = new Random().Next(0, 100);
        array[i] = Convert.ToDouble($"{a},{b}");
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}