Console.WriteLine("Введите несколько чисел: ");
int[] numbers = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();;

void PrintArray(int[] numbers)
{
    int result = 0;
    int = numbers.Length;
    while (i < count)
    {
        Console.Write($"[{numbers[i]}]");
        i++;
    }
}
int[] array = new int[numbers.Length];
PrintArray(numbers);
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) count++;
}
Console.WriteLine();
Console.WriteLine($"Колличество цифр больше нуля = {count}");
