/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void AllNaturals (int max)
{
    if (max > 1) 
    {
        Console.Write(max + ", ");
        AllNaturals(max - 1);
    }
    else 
        Console.WriteLine("1.");
    
}

Console.Write("Enter number N: ");
AllNaturals(Convert.ToInt32(Console.ReadLine()));