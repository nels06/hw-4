// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string[] MakeArray(int n)
{
    string[] newArray = new string[n];

    Console.WriteLine("Введите элементы массива: ");

    for (int i = 0; i < n; i++)
    {
        newArray[i] = Console.ReadLine();
    }

    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("Результат: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.Write(" ]");
}


Console.Write("Введите размер массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if(!isNumber || num < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

PrintArray(MakeArray(num));