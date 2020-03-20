using System;
using System.Collections.Generic;
using System.Linq;

namespace ParseCmdLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            //www.youtube.com/watch?v=cX6M_h5OCR0 - 26:00

            Stack<string> arguments = new Stack<string>(args.Reverse());

            string verb = "";

            //if(!arguments.TryPop(out verb))
            //{
            //    Console.WriteLine("no actins pecified");
            //}

            if (arguments.Count >= 1)
            {
                verb = arguments.Pop();
            }
            Console.WriteLine($"Verb: {verb}");

            string modifier;

            switch (verb.ToUpper())
            {
                case "HELLO":
                    if(arguments.TryPop(out modifier))
                    {
                        switch (modifier.ToUpper())
                        {
                            case "EVERYONE":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("HELLO EVERYONE");
                                Console.ResetColor();
                                Console.WriteLine($"And here is rest: {String.Join(',', arguments)}");                               
                                break;
                            case "YOUTUBE":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("HELLO YOUTUBE");
                                Console.ResetColor();
                                Console.WriteLine($"And here is rest: {String.Join(',', arguments)}");                               
                                break;
                            default:
                                arguments.Push(modifier);
                                Console.WriteLine($"{modifier} not recognised");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{verb} Recognised!! And here is rest: {String.Join(',', arguments)}");
                    }
                    break;
                case "GOODBYE":
                    Console.WriteLine($"{verb} Recognised!! And here is rest: {String.Join(',', arguments)}");
                    break;
                default:
                    Console.WriteLine($"Sorry - I do not know what {verb} is");
                    break;
            }

            // -------------------  Solution 1 -----------------
            //string verb = args[0];
            //String[] rest = args.Skip(1).Take(args.Length - 1).ToArray();
            //Console.WriteLine($"Verb: {verb}");
            //Console.WriteLine($"Rest: {String.Join(',', rest)}");
            //Console.WriteLine("Hello " + String.Join(' ', args) + "!");

            //switch (verb.ToUpper())
            //{
            //    case "HELLO":
            //        Console.WriteLine($"{verb} Recognised!! And here is rest: {String.Join(',', rest)}");
            //        break;
            //    case "GOODBYE":
            //        Console.WriteLine($"{verb} Recognised!! And here is rest: {String.Join(',', rest)}");
            //        break;
            //    default:
            //        Console.WriteLine($"Sorry - I do not know what {verb} is");
            //        break;
            //}
            //
            //-----------------End of Solution 1 ----------------------------------
        }
    }
}
