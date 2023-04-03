using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5
{
      class ExeptionClass
    {
        public static void Main(string[] args)
        {
            int[] integerArray = new int[] { 211, 321, 431,541, 651 };
            Console.WriteLine("Index Value");
                for(int i=0;i<integerArray.Length;i++)
            {
                Console.WriteLine("  "+i +"   "+integerArray[i]);
            }

            try
            {
                Console.WriteLine("\nInside Try and Catch");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("  " + i + "   " + integerArray[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
               
            }
            finally { Console.WriteLine("\n\nInside Finally Block ."); }
        
        }
    }
}
