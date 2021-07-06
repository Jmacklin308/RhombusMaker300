using System;
using System.Runtime.InteropServices;

//      *     
//     ***    
//    *****   
//   *******
//  *********
// ***********
//

namespace whileLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int rows = 90;
            string playerChar = "#";

            
            
            //Create the top half of the diamond
            for (int row = 0; row < rows; row++)
            {
                for (int spaces = 0; spaces <  rows - row ; spaces++)
                {
                    Console.Write(" ");
                }
                
                for (int column = 0; column <= row * 2 ; column++)
                {
                    Console.Write(playerChar);

                }
                Console.WriteLine(); //wrap around again
            }
            //Draw bottom half
            for (int row = rows; row >= 0; row--)
            {
                for (int spaces = 0; spaces < rows - row ; spaces++)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column <= row * 2 ; column++)
                {
                    Console.Write(playerChar);

                }
                Console.WriteLine(); //wrap around again
            }
        }
    }
}