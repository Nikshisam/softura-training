using System;
class CovidTask
{
public static void Main()
{
string travel,temp,cough;
Console.WriteLine("Have you travelled in past 10 days ");
travel=Console.ReadLine();
if(travel=="yes")
{
Console.WriteLine("Do You have temperature?");
temp=Console.ReadLine();

if(temp=="yes")
{
Console.WriteLine("Do you have cough or sneeze");
cough=Console.ReadLine();

if(cough=="yes")
{
Console.WriteLine("You are requested to take up a swab test ");
}
else
{
Console.WriteLine("You Are preferred to be in quarantine and take appropriate medicine");
}
}
 else
{
Console.WriteLine("You are preferred to take some hot water");

}
}
else
{
Console.WriteLine("You have Nothing");
}

}
}
