using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
           
         
            while (true)
            {
                int letter = 0, words = 0, sentence = 0;
                bool wrd= false;
                
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                
                Console.CursorVisible = false;
              
            Console.Write("\n Enter your Text:");
            string Text =Console.ReadLine();

            for (int i = 0; i < Text.Length; i++)
            {
                char ch = Text[i];
                if (char.IsLetter(ch))
                {
                    letter++;

                    wrd = true;

                }
                else
                {
                    if (wrd)
                    {
                        words++;
                        wrd = false;
                    }
                    if (ch == '.' || ch == '?' || ch == '!')
                        sentence++;
                }
            }
                
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n --- Text Analysis ---\n");
            Console.WriteLine(" Letters:{0}  ", letter);
            Console.WriteLine("\n Words:{0}  " , words);
            Console.WriteLine("\n Sentences:{0}  ", sentence);
          

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

                Console.Write("\n\n Do you want to analize another Text(y/n)?");
                char ask = char.Parse(Console.ReadLine());

                if (ask != 'y') 
                    break;
            }
            Console.ReadKey();
        }
    }
}
