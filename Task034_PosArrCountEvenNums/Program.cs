// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
int countPosNums = 0;

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
        countPosNums++;
}
Console.WriteLine($"Количество четных чисел в этом массиве: {countPosNums}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
} 

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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