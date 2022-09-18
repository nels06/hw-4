// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
bool isNumberA = int.TryParse(Console.ReadLine(), out int numA);
Console.Write("Введите число B: ");
bool isNumberB = int.TryParse(Console.ReadLine(), out int numB);

if(!isNumberA || !isNumberB || numB < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int ToPow(int numA, int numB)
{
    int res = 1;
    for (int i = 0; i < numB; i++)
    {
        res *= numA;
    }
    return res;
}

Console.WriteLine($"Результат: {ToPow(numA, numB)}");