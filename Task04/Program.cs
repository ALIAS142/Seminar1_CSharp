//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter number: ");

string strNumberN = Console.ReadLine();

int NumberN = Convert.ToInt32(strNumberN);

int NumberK = NumberN * (-1);

do
{   
    
    System.Console.WriteLine(NumberK);
    NumberK = NumberK + 1;
} 
while (NumberK <= 0);

if (NumberK >= 0);
{   
    do
    {
       System.Console.WriteLine(NumberK);
       NumberK = NumberK + 1;
      
    }
    while (NumberK <= NumberN);

} 

