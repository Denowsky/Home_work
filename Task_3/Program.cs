// See https://aka.ms/new-console-template for more information
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Привет, введите число: ");
string strNum1 = Console.ReadLine();
int firstNum = Convert.ToInt32(strNum1);
if ((firstNum%2) == 0)
{
    Console.WriteLine(firstNum + " - чётное число");
}
else 
{
    Console.WriteLine(firstNum + " - нечётное число");
}