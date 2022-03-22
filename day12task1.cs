using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Nikshidha
{
    class day11task2
    {
        public static void Main()
        {

            FileStream fs = new FileStream("D:\\nikshi\\programming\\deserts.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Butterscotch Crunch");
            str.Add("Rasamalai");
            str.Add("Choco truffle");
            str.Add("Bread Halwa");
            str.Add("Badam milkshake");
            foreach (string d in str)
            {
                bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("D:\\nikshi\\programming\\deserts.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo("D:\\nikshi\\programming\\deserts.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }
    }
}

    

