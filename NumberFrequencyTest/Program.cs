using System;

namespace NumberFrequencyTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if(args.Length<1)
            {
                Console.WriteLine("Must enter 1 parameter of value \"proc\" or \"oo\"");
                return;
            }
            switch (args[0]) { 
                case "proc":
                    Console.WriteLine("Procedural");
                    NumberFrequencyProc nfp = new NumberFrequencyProc();
                    nfp.findFrequencies(long.MaxValue);
                    break;
                case "oo":
                    Console.WriteLine("Object Oriented");
                    NumberFrequencyOO nfoo = new NumberFrequencyOO();
                    nfoo.findFrequencies(long.MaxValue);
                    break;
                default:
                    Console.WriteLine("oops!");
                    break;
            }
        }
    }
}
