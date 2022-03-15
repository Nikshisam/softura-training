using System;
class multiplyTask
{
public static void Main()
{
Console.WriteLine("enter the number");
int num=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<21;i++)
{
int res=num*i;
Console.WriteLine(num+"*"+i+"="+res);
}
}
}
