using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace lynq
{
    class apr12_task
    {
       


            SqlConnection con = new SqlConnection("data source=LAPTOP-FUS4MA7U; database=trail;user id=sa; password=P@ssw0rd");
            public void create()
            {
                SqlConnection con = new SqlConnection("data source=LAPTOP-FUS4MA7U; database=trail;user id=sa; password=P@ssw0rd");
                con.Open();
                SqlCommand cmd = new SqlCommand("create table Enrollment ( Sno int,  Name char(20),  Sid int,  Sage  int)", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("table created ");
            }

            public void insert(int Sno, string Name, int Sid, int Sage)
            {
                string sqlqry = "insert Enrollment values(" + Sno + ",'" + Name + "'," + Sid + "," + Sage + ")";
                SqlCommand cmd = new SqlCommand(sqlqry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("row inserted");
            }

            public void update()
            {
                string sqlqry = "update Enrollment Set sid=56,sage=25 where Name='yoga'";
                SqlCommand cmd = new SqlCommand(sqlqry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("row updated");
            }
            public static void Main(string[] args)
            {
                apr12_task obj = new apr12_task();
                //Console.WriteLine("enter sno");
                //int Sno = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("enter name");
                //string Name = Console.ReadLine();
                //Console.WriteLine("enter student id");
                //int Sid = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("enter student age");
                //int Sage = Convert.ToInt32(Console.ReadLine());

                obj.create();
                //obj.insert(Sno, Name, Sid, Sage);
               // obj.update();


            }

        }
    }
