﻿using System;

namespace Testcode
{
    class Program
    {
        static void Main(string[] args)
        {



          

            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
