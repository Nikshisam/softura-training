using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace simple_activity_mar15
{
    class Simple_Activity
    {
        SqlConnection con = new SqlConnection("Data source = LAPTOP-FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
        public void ProductList()
        {
            string prodlist = "Select *from Product_List";
            SqlCommand cmd = new SqlCommand(prodlist, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProdID : " + dr[0] + " " + "ProdName : " + dr[1] + "  " + "Price : " + dr[2] + "  " + "DateOdManu : " + dr[3] + "  " + "ExpiryDate : " + dr[4]);
            }
        }
        public void CustomerCal()
        {
            Console.WriteLine("Valuable Customer,Your CustomerID");
            string CustID = Console.ReadLine();
            SqlConnection con = new SqlConnection("Data source = LAPTOP-FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
            string Excust = "select*from Customer_table where Name ='" + CustID + "'";
            SqlCommand ncmd = new SqlCommand(Excust, con);
            con.Open();
            SqlDataReader dr = ncmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("CustID : " + dr[0] + " " + "CustomerName : " + dr[1] + " " + "Gender :" + dr[2] + " " + "DateOfBirth: " + dr[3] + " " + "ContactNO: " + dr[4] + " " + "EmailId: " + dr[5] + "  " + " City: " + dr[6]);
            }
            Simple_Activity obj1 = new Simple_Activity();
            obj1.ProductList();
            con.Close();

        }
        public void FrshCus()
        {
            Console.WriteLine("Your Name Please:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Your Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Your Date Of Birth:");
            string DateOfBirth = Console.ReadLine();
            Console.WriteLine("Number for Contact:");
            string ContactNo = Console.ReadLine();
            Console.WriteLine("Your MailID:");
            string EmailID = Console.ReadLine();
            Console.WriteLine("Your City(Chennai/Mumbai):");
            string City = Console.ReadLine();
            string CustDetails = "insert Customer_List(CustomerName,Gender,DateOfBirth,ContactNo,EmailID,City) values('" + CustomerName + "','" + Gender + "','" + DateOfBirth + "','" + ContactNo + "','" + EmailID + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(CustDetails, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Customer Details inserted !!!");
            //SqlDataReader dr = cmd.ExecuteReader();
            while (true)
            {
                SqlConnection con1 = new SqlConnection("Data source = LAPTOP-FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
                SqlCommand cmd1 = new SqlCommand("select CustID  from Customer_List where CustomerName='" + CustomerName + "'", con1);
                con1.Open();
                //cmd1.ExecuteNonQuery();
                SqlDataReader sdr = cmd1.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine("Enter Your Customer ID : " + sdr[0]);
                }
                con1.Close();
                break;
            }
            Console.WriteLine();
            Simple_Activity obj1 = new Simple_Activity();
            obj1.ProductList();
            con.Close();
        }
        public void purchaseList()
        {
            Console.WriteLine("Your CustomerID Please:");
            string cust = Console.ReadLine();
            Console.WriteLine("ProductId of The selected Product:");
            string purch = Console.ReadLine();
            Console.WriteLine("How Many:");
            int NoOfItem = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = LAPTOP-FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select Price* " + NoOfItem + " ,ProdID,ProdName,Price from Product_List where ProdID = " + purch + "", con);
            //SqlCommand cmd = new SqlCommand(pl, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                int Total = Convert.ToInt32(dr[0]);
                Console.WriteLine("ProdID : " + dr[1] + " " + "   ProdName : " + dr[2] + "  " + "  Price : " + dr[3] + "  Total Amount :  " + Total);
                string insnew = "insert Purchase_List (CustID,ProdID,Quantity,TotalAmount) values (" + cust + "," + purch + "," + NoOfItem + "," + Total + ")";
                SqlConnection con1 = new SqlConnection("Data source = LAPTOP-FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
                SqlCommand cmd1 = new SqlCommand(insnew, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                Console.WriteLine("We are happy to have a valuable Customer Like You--- Thank You--- Visit Again");
                //Console.WriteLine("purchase Details Inserted");
                con1.Close();
            }
            con.Close();
            //Simple_Activity obj = new Simple_Activity();
            //obj.ShowBill(cus);
        }
        public void ShowBill(string cust)
        {
            string bill = "select  CustID,ppl.ProdID,ProdName,Price,Quantity,TotalAmount from Product_List pt join Purchase_list ptt on pt.ProdID = ppl.ProdID where CustID=" + cust + "";
            SqlCommand cmd = new SqlCommand(bill, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(" CustomerID : " + dr[0] + " ProductID : " + dr[1] + " ProdName : " + dr[2] + " Quantity : " + dr[3] + " TotalAmount : " + dr[4] + " Date : " + dr[5]);
            }
            con.Close();
        }
        public void showPurchase()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your CustomerID To View Your Purchase Information:");
            int cuss =Convert.ToInt32( Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = LAPTOP-FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
            string purch = "select CustID,ppl.ProdID,ProdName,Price,Quantity,TotalAmount from Product_List pp join Purchase_List ppl on pp.ProdID = ppl.ProdID where CustID=" + cuss + "";
            SqlCommand cmd = new SqlCommand(purch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            Console.WriteLine("  YOUR PURCHASE HISTORY ");
            while (dr.Read())
            {
                //Console.WriteLine(" PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public void showPurchaseBDate()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Date On Which You need the details:");
            var Date = Convert.ToString(Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = LAPTOP_FUS4MA7U; database = Activity; user id = sa; password = P@ssw0rd");
            string purch = "select  CustID,ppl.ProdID,ProdName,Price,Quantity,TotalAmount,Purchasedate from Product_List pp join Purchase_List ppl on pp.ProdID = ppl.ProdID where Purchasedate=," + Date + "'";
            SqlCommand cmd = new SqlCommand(purch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("This was the Purchase history on the mentioned Date");
            while (dr.Read())
            {
                //Console.WriteLine("                                        PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public static void Main()
        {
            Console.WriteLine("WELCOME  ");
            Simple_Activity obj = new Simple_Activity();
            Console.WriteLine("Are You An Existing Customer (Y/N) Or If You want to know your Purchase History Enter VIEW");
            string ver = Console.ReadLine();
            switch (ver)
            {
                case "VIEW":
                    obj.CustomerCal();
                    break;
                case "Y":
                    obj.ProductList();
                    break;
                case "N":
                    obj.FrshCus();
                    break;
            }

            obj.purchaseList();
            obj.showPurchase();
            obj.showPurchaseBDate();

        }
    }
}