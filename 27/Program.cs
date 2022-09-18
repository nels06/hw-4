// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if(!isNumber)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int GetSum(int num)
{
    int res = 0;
    
    num = Math.Abs(num);

    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}

Console.WriteLine($"Результат: {GetSum(num)}");