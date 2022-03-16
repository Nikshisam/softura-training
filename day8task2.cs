using System;
class calculatetax1

{
public void calculateVAT()

{
int price;
float vat,ptp;
Console.WriteLine("enter the price of the product:");
price=Convert.ToInt32(Console.ReadLine());
vat=price*20/100;
ptp=vat+price;
Console.WriteLine("The amount to be paid after VAT is"+ptp);
}
}
class calculatetax2 : calculatetax1
{
public void calculateGST(int price)
{
float gst=price*12/100;
float ptp1=gst+price;
Console.WriteLine("The amount to be paid after GST is"+ptp1);
}
}
class inherit
{
public static void Main()
{
calculatetax1 obj=new calculatetax1();
calculatetax2 obj1=new calculatetax2();
obj.calculateVAT();
obj1.calculateGST(54);
}
}


