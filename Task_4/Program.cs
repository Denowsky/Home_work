/*
Задача 8: Напишите программу,
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Привет, введите число: ");
string strNum1 = Console.ReadLine();
int firstNum = Convert.ToInt32(strNum1);
int count = 0;
do
{
    count = count + 2;
    Console.Write(count + ", ");
} while (count < (firstNum - 3));
count = count + 2;
    Console.Write(count + " ");