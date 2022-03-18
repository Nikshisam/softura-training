using System;
class level
{
string name;
int age;
public level()
{
Console.WriteLine("Enter your name");
 name= Console.ReadLine();
Console.WriteLine("Enter your age");
age=Convert.ToInt32(Console.ReadLine());
}
public level( string name,int age)
{

 
Console.WriteLine("your name is " +name+ "\n"+"your age is"+age);
}
}
class members
{
public static void Main()
{

level obj=new level();



level obj1=new level("nikshi",21);
}
}
