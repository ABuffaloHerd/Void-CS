using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Void_CS.Handler
{
    class TextHandler
    {
        // Prints text like it's being typed to the console.
        public static void Print(string text, int timeout = 15)
        {
            // Default timeout is 23ms
            char[] array = text.ToCharArray();

            foreach(char character in array)
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(timeout);
            }

            Console.Write("\n");
        }

        public static void ManualSleep(int timeMS)
        {
            System.Threading.Thread.Sleep(timeMS);
        }

        public static void PrintSeparator(int length = 10, int leadingSpace = 0, int trailingSpace = 0)
        {
            for (int leading = 0; leading < leadingSpace; leading++)
            {
                Console.Write("\n");
            }

            for (int equals = 0; equals < length; equals++)
            {
                Console.Write("=");
            }
            Console.Write("\n");

            for (int trailing = 0; trailing< trailingSpace; trailing++)
            {
                Console.Write("\n");
            }
        }
    }
}
