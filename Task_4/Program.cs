// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, введите число: ");
string strNum1 = Console.ReadLine();
int firstNum = Convert.ToInt32(strNum1);
int count = 0;
do
{
    count = count + 2;
    Console.Write(count + ", ");
} while (count < (firstNum - 1));