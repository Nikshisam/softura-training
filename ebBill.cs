using System;
class ebBill
{
public static void Main()
{
int unit,res1,res2,res3,res4;
string name;
Console.WriteLine("Enter your name: ");
name=Console.ReadLine();
Console.WriteLine("Enter No.Of.Units: ");
unit=Convert.ToInt32(Console.ReadLine());
if(unit<=200)
{
res1=unit*2;
Console.WriteLine("amount is"+res1);
}
else if (unit>200&&unit<=350)
{
res2=200*2+(unit-200)*3;
Console.WriteLine("Amount is"+res2);
}
else if(unit>350&&unit<=500)
{
res3=200*2+150*3+(unit-350)*5;
Console.WriteLine("Amount is"+res3);
}
else 
{
res4=200*2+150*3+150*5+(unit-500)*7;
Console.WriteLine("Amount is"+res4);
}
}
}