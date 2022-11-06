// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
int [] printMass(int number) {
    int[] arry = new int[number];
    for (int i = 0; i < number; i++){
    Console.Write($"Введите число {i}: ");
    arry[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arry;
}
Console.Write($"Введите количество эллементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] res = printMass(number);
foreach (int i in res)
{
    System.Console.Write("{0} ", i);
}