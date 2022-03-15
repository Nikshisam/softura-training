using System;
class array
{
public static void Main()
{
string[][] products=new string[4][];
products[0]=new string[]{"list","product catagory","number of items"};
products[1]=new string[]{"a","biscuits","  ","there are 4 times"};
products[2]=new string[]{"b","chocolates","  ","there are 5 times"};
products[3]=new string[]{"c","drinks","  "," ","there are 6 times"};
for(int i=0;i<products.Length;i++)
{
for(int j=0;j<products[i].Length;j++)
Console.Write(products[i][j]+"\t");
Console.WriteLine();
}}}