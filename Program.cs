/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/*
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
AllNaturals(Convert.ToInt32(Console.ReadLine())); */

/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumOfElements(int first, int last)
{
    if(first == last)
        return first;
    return first + SumOfElements(first + 1, last);
}
Console.Write("Enter first number (M): ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first number (N): ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of natural numbers from {numberM} to {numberN} is {SumOfElements(numberM,numberN)}");