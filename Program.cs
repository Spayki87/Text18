using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Консольное_выражение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char openBracket = '(';
            char closeBracket = ')';

            int depth = 0;
            int maxDepth = 0;

            Console.WriteLine("Ведите скобочное вырожение:");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == openBracket)
                {
                    depth++;

                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }
                else if (text[i] == closeBracket)
                {
                    depth--;
                }

                if (depth < 0)
                {
                    break;
                }
            }

            if (depth == 0)
            {
                Console.WriteLine("Скобочное вырожение верное.");
                Console.WriteLine("Скобочная глубина - " + maxDepth);
            }
            else
            {
                Console.WriteLine("Скобочное вырожение не верное.");
            }
        }
    }
}
