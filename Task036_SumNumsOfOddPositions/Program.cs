// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
int sumNumOddPos = 0;

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
        sumNumOddPos += numbers[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна: {sumNumOddPos}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}