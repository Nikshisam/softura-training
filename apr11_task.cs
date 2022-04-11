using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lynq
{
    class apr11_task
    {
        public static void Main(string[] args)
        {
            IList<Doctor> DocData = new List<Doctor>()
            {
                new Doctor() { DoctorID = 1, DoctorName = "Ananya", Age = 22, SpecializationID=1 },
                new Doctor() { DoctorID = 2, DoctorName = "Harini", Age = 23, SpecializationID=2},
                new Doctor() { DoctorID = 3, DoctorName = "Anirudh", Age = 28,SpecializationID=1},
                new Doctor() { DoctorID = 4, DoctorName = "Gautham", Age = 21,SpecializationID=3}
                

            };
            IList<Specialist> BranchData = new List<Specialist>()
            {
                new Specialist() { SpecializationID = 1, SpecializationName = "Dentist" ,Shift="day"},
                new Specialist() { SpecializationID = 2, SpecializationName = "Gynaecologist", Shift="noon"},
                new Specialist() { SpecializationID = 3, SpecializationName = "Peadiatrician" ,Shift="night"}
            };
            var JoinData = DocData.Join(
               BranchData,
                doc => doc.SpecializationID,
                brd => brd.SpecializationID,
                
                (doc, brd) => new
                {
                    DoctorName = doc.DoctorName,
                    SpecializationName = brd.SpecializationName,
                    
                }
                );
            foreach (var v in JoinData)
            {
                Console.WriteLine("The Doctor name is "+v.DoctorName+",he/she is Specialized in " +v.SpecializationName);
            }


        }
        class Doctor
        {

            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
            public int Age { get; set; }
            public int SpecializationID { get; set; }

        }
        class Specialist
        {
            public int SpecializationID { get; set; }
            public string SpecializationName { get; set; }
            public string Shift{get; set;}
        }
    }
}

