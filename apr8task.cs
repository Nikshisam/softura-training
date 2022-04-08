using System;
using System.Collections.Generic;
using System.Text;

namespace lynq
{
    class apr8task
    {
		class Task0804
		{
			static int numbergoat(int eyes,
									int Legs)
			{
				int number = 0;
				number = (Legs) - (eyes - 1);
				number = number / 2;
				return number;


			}


			public static void Main()
			{
				int eyes = 52, Legs = 80;
				int Goat = numbergoat(eyes, Legs);


				Console.WriteLine("Goat = " +
								Goat);
				Console.WriteLine("Ducks = " +
								(Goat - 2));
			}
		}
	}




}
    

