using System;
class day8
{
float num1,num2,res1,res2,res3,res4;
public void addsub()
{
Console.WriteLine("Enter two Numbers:");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());

res1=num1+num2;
res2=num1-num2;
Console.WriteLine("sum is"+res1);
Console.WriteLine("difference is"+res2);
}
public void muldiv()
{
res3=num1*num2;
res4=num1/num2;
Console.WriteLine("product is"+res3);
Console.WriteLine("Quotient is"+res4);
}
public static void Main()
{
day8 obj=new day8();
obj.addsub();
obj.muldiv();
}
}


