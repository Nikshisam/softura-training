using System;
class employee
{
public virtual void recievedetails()
{
long empid;
int yoe;
string name,gen;
Console.WriteLine("Enter employeeId: ");
empid=Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Enter name");
name=Console.ReadLine();
Console.WriteLine("Enter your gender (male/female):");
gen=Console.ReadLine();
Console.WriteLine("How many years of experience do you have?");
yoe=Convert.ToInt32(Console.ReadLine());
}
}
class salcal:employee
{
public void calculation()
{
Console.WriteLine("Which department you are from (sales&marketing/production)");
string dept=Console.ReadLine();
Console.WriteLine("Your salary please:");
long salary=Convert.ToInt64(Console.ReadLine());

if(dept=="sales&marketing")
{
Console.WriteLine("Your bonus is added with 20%");
long bonus1=salary/5;
salary=bonus1+salary;
}
else
{
Console.WriteLine("your bonus is added with 10%");
long bonus2=salary/10;
salary = bonus2+salary;
}
Console.WriteLine("Your salary is "+salary);
}
}
class main
{
public static void Main()
{
salcal obj1=new salcal();
obj1.recievedetails();
obj1.calculation();
}
}






