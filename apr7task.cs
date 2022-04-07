using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lynq
{
    class apr7task
    {
        public static void Main()
        {
            IList<bookinfo> Binfo = new List<bookinfo>()
            {
            new bookinfo() { BookID = 301, BookName = "The Wreck Of Titan", AuthorName = "XXX", price = 300 },
            new bookinfo() { BookID = 302, BookName = "Poniyin Selvan", AuthorName = "YYY", price = 200 },
            new bookinfo() { BookID = 303, BookName = "Tom And Jerry", AuthorName = "ZZZ", price = 800 },
            new bookinfo() { BookID = 304, BookName = "Panchatantra", AuthorName = "WWW", price = 200 },
            new bookinfo() { BookID = 305, BookName = "Arabian Nights", AuthorName = "XXy", price = 1000 }
            };

            var qry = from bookinfo in Binfo
                      select bookinfo;

            foreach (var q in qry)
                Console.WriteLine("AuthorName:"+q.AuthorName+"BookID:"+q.BookID+"BookName:"+q.BookName+"Price:"+q.price);


            var BQry = from stud in Binfo
                       where stud.AuthorName.Contains("zzz")
                       select stud;
            foreach (var names in BQry)
                Console.WriteLine("The book Name is"+names.BookName+"The Author Name is "+names.AuthorName);





            var pri = from price in Binfo
                     orderby price.price
                     select price;
            foreach (var pric in pri)
                Console.WriteLine("The Book is"+pric.BookName+"the Price Is"+pric.price);
            var auqry = from a in Binfo
                        orderby a.AuthorName ascending
                        select a;
            foreach (var a in auqry)
                Console.WriteLine(a.AuthorName + "   " + a.BookName);

        }

    }
    class bookinfo
    {
        public int BookID;
            public string BookName;
        public string AuthorName;
        public int price;
    }

}
