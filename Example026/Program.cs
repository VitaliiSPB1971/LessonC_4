// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
double countNumber(double number)
{
    double count = 0;
    while (number != (long)number)
    {
        number *= 10;
        count++;
    }
    Console.WriteLine($"{count} {number}");
    return number;
}
double res = countNumber(10);
