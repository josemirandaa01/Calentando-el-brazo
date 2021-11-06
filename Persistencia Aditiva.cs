using System;
					
public class Program
{
	public static void Main()
	{
		 int c,i = 0;

            Console.WriteLine("Inserte un número");

            c = Convert.ToInt32(Console.ReadLine());

		
		while (c > 9)
		{
		    
		   int temp1 = 0;
            while (c != 0)
            {

                int temp2 = c % 10;
                temp1 = temp1 + temp2;
                c = c - temp2;
                c = c / 10;
                
            }
c = temp1;
i++;
		
		}
		
		Console.WriteLine("La persistencia es" + " " + i);
		
	}
}
