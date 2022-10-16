int max = 0;
int min = 0;
Console.WriteLine("Привет, введите первое число: ");
string strNum1 = Console.ReadLine();
int firstNum = Convert.ToInt32(strNum1);
Console.WriteLine("Введите Второе число: ");
string strNum2 = Console.ReadLine();
int secondNum = Convert.ToInt32(strNum2);
if (firstNum > secondNum)
{
    max = firstNum;
    min = secondNum;
}
else
{
    max = secondNum;
    min = firstNum;
}
Console.WriteLine("max = "+ max + ", min = " + min);