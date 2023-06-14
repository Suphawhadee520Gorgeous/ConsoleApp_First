using  System;
namespace ConsoleApp_First
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Loop While
            int y = 0;
            while (y < 3)
                {
                Console.WriteLine("While " + y);
                y++;
                }
                Console.WriteLine("Loop ended"); //LOOP END
            #endregion


            #region //Foreach BrandTV
            string[] BrandTV = { "LG", "SONY", "SAMSUNG", "TCL", "JVC" };
            foreach (string television in BrandTV) 
            {
                Console.WriteLine("BrandJ_Yayee " + television);
            }
            #endregion
        }
    }
}
/* if (20>18)
 *  {
 *  Console.WriteLine("20 is greater than 18");
    }
*/


/* if else 
 * int time = 20;
 * if (time<18)
 * {
   Console.WriteLine("Good day.");
   }
   else
   {
   Console.WriteLine("Good bye");
   }
*/


/* if else if else
 * int time = 22;
 * if (time <10) 
 * {
 * Console.WriteLine("Good boy");
 * } else if (time <20) {
 * Console.WriteLine("Good gril");
 * } else {
 * Console.WriteLine("Good");
 * }
 */


/* swich(expression)
 * {
 * case resuil_expression1 ://block of code to be executed.   break;
 * case resuil_expression2 ://block of code to be executed.   break;
 * defualt://block of code to be executed.  break;
 * }
 */


/* for 
 * (int i= 0; i <5; i++)
 * {
 * Console.WriteLine("Counter" + i);
 * }
 */


/* for 
 * (int i= 0; i <5; i++)
 * {
 *  Console.WriteLine("Outer Loop:" + i); //3 time
 * 
 *  for(int_i= 0;_i <5; ++_i)
 *  {
 *  Console.WriteLine("Inner Loop:" + i); //2 time
 *  }
 * }
 */