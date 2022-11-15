// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*(НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */

int ResultNumbers(int n , int m)
{
if (n==m)
 return n; 
 else if (n < m) return m + ResultNumbers(n, m - 1);
 else return m + ResultNumbers(n, m + 1);  
 
}


Console.Clear();
Console.Write("Введите число - начало диапазона: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число - конец диапазона: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(n,m));

