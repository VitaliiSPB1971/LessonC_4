// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int numberSum(int number){
    int summa = 0;
    while(number > 0) {
        int digit = number % 10;
        if(digit != 0) {
            summa = summa + digit;
        }
        number = number / 10;
    }
    return summa;
}
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = numberSum(number);
Console.WriteLine($"Результат: {result}");
