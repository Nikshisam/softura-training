﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
        [Serializable]
        class Employeedets
        {

            public string name = "Nikshi";
            public int age = 21;
            public string Empid = "211518205101";
            public string gender = "Female";

        }
        class slsation
        {
            public void SeretoFile()
            {
                Employeedets sobj = new Employeedets();
                FileStream fs = new FileStream(@"D:\nikshi\programming\Empdets.txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter f = new BinaryFormatter();
                f.Serialize(fs, sobj);
                fs.Close();
            }
            public void Dserial()
            {
                FileStream fs = new FileStream(@"D:\nikshi\programming\Empdets.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter f = new BinaryFormatter();
                Employeedets stu = (Employeedets)f.Deserialize(fs);
                Console.WriteLine(stu.name);
                Console.WriteLine(stu.age);
                Console.WriteLine(stu.gender);
                Console.WriteLine(stu.Empid);



            }

            public static void Main()
            {
                slsation lobj = new slsation();
                lobj.SeretoFile();
                lobj.Dserial();
                Console.ReadLine();

            }
        }
}
