// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите любое натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int temp = num;
    int count = 0;
    while (temp > 0)
    {
        count++;
        temp = temp / 10;

    }
    int[] digits = new int[count];
    for (int i = count - 1; i >= 0; i--)
    {
        digits[i] = num % 10;
        num = num / 10;
    }
    for (int i = 0; i < count; i++)
    {
        int lastDigit = num % 10;
        num = num / 10;
        if (i > 0)
            {
                Console.Write(",");
            }
            Console.Write(digits[i]);
    }
}
else
    {
        Console.WriteLine("Некорректный ввод");
    }
