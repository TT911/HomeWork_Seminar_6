//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);

int posnumber = 0;

for (int i = 0; i < numbers.Length; i++) 
    {
        if (numbers[i] > 0) 
        posnumber++;
    }
Console.WriteLine($"Массив из {numbers.Length} элементов, количество положительных чисел {posnumber}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++) 
    {
        numbers[i] = new Random().Next(-10,11);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

