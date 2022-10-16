// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, введите первое число: ");
string strNum1 = Console.ReadLine();
int firstNum = Convert.ToInt32(strNum1);
Console.WriteLine("Введите Второе число: ");
string strNum2 = Console.ReadLine();
int secondNum = Convert.ToInt32(strNum2);
Console.WriteLine("Введите третье число: ");
string strNum3 = Console.ReadLine();
int thirdNum = Convert.ToInt32(strNum3);

int[] newArray  = { firstNum, secondNum, thirdNum };
int max = newArray.Max();

Console.WriteLine("max = "+ max);