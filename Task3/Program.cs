// Напишите программу, которая принимает на вход целое число из отрезка
// [10, 99] и показывает наибольшую цифру числа

Console.WriteLine("Введите любое число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <=99)
{
    int firstDigit = num / 10;
    int lastDigit = num % 10;
    if (firstDigit >= lastDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(lastDigit);
    }
}
else
{
    Console.WriteLine("Некорректный ввод");
}