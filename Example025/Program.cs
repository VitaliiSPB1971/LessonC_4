// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Stepen(int number, int increment){
    int result = 1;
    for (int i = 0; i < increment; i++)
    {
        result = result * number;
    }
    return result;
}
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую степень:");
int increment = Convert.ToInt32(Console.ReadLine());
int result = Stepen(number, increment);
Console.Write($"Результат: {result}");