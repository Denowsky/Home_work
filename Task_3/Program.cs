// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, введите первое число: ");
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