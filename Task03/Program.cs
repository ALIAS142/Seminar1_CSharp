// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Enter number :");

string strNumber = Console.ReadLine();

int Number1 = Convert.ToInt32(strNumber);

if (Number1 == 1)
{
    System.Console.WriteLine("Monday");
}
else 
if  (Number1 == 2)
{
    System.Console.WriteLine("Tuesday");
}

else 
if (Number1 == 3)
{
    System.Console.WriteLine("Wednsday");
}
    else 
    if (Number1 == 4)
{
    System.Console.WriteLine("Thursday");
}
else 
if (Number1 == 5)
{
    System.Console.WriteLine("Friday");
}
else
 if (Number1 == 6)
{
    System.Console.WriteLine("Saturday");
}
else
if (Number1 == 7)
{
    System.Console.WriteLine("Sunday");
}
else {
    Console.WriteLine("Absent day");
}

