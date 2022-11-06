//Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц,
// если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.
Random rnd = new Random();
int totalTrue = 0, totalFalse = 0;

for (int ctr = 0; ctr < 8; ctr++) {
    bool value = NextBoolean();
    if (value)
       totalTrue++;
    else
       totalFalse++;
}
    if (totalTrue++ > totalFalse++)
       Console.WriteLine("TRUE");
    else
       Console.WriteLine("False");

bool NextBoolean()
{
   return rnd.Next(0, 2) == 1;
}
