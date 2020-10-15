using System;

namespace Ovning2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;


            Console.WriteLine("Skriv ett heltal:  ");

            x = int.Parse(Console.ReadLine());
            
            if ( x % 2 == 0)
            {

                Console.WriteLine("{0} är jämnt!", x);
            }
            else
            {
                Console.WriteLine("{0} är udda!!", x);

                
            }


            Console.ReadKey();
        }
    }
}
