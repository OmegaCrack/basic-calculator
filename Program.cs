using System;

namespace Conditional
{
    class IfStatement {
        public static void Main(string[] args)
        {
            
            int outter = 6;
            int inner = 5;

            switch (outter) {
                case 1:
                    Console.WriteLine("Outter case 1");
                    break;
                case 2: 
                    Console.WriteLine("Outter case 2");
                    switch (inner) {
                        case 1:
                            Console.WriteLine("Inner case 1");
                            break;

                        case 2:
                            Console.WriteLine("Inner case 2");
                            break;
                        case 3:
                            Console.WriteLine("Inner case 3");
                            break;
                        default:
                            Console.WriteLine("Default Inner run");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Default Outter run");
                    break;
            }

            Console.ReadKey();
            
        }
    }
}