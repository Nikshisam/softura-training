using System;
class switchtask
{
public static void Main()
{
Console.WriteLine("which package do you Belong to?");
int package=Convert.ToInt32(Console.ReadLine());
switch(package)
{
case 1:
Console.WriteLine("south special \n children's club\n movies\n the rate is Rs.250");
break;
case 2:
Console.WriteLine("news\n sports\n movies\n Regional-2\n The rate is Rs.450");
break;
case 3:
Console.WriteLine("discovery\n national\n history\n The rate is Rs.350");
break;
}
}
}