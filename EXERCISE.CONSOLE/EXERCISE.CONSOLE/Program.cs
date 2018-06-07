using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE.CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            FiveASide.ChooseSides(new Player[]
            {
                new Player("a", 90),
                new Player("b", 12),
                new Player("c", 13),
            });


            string s = "CiaO2 ";
            char[] list = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if(isLower(list[i]))
                {
                    list[i] = ToUpper(list[i]);
                }
                else if (isUpper(list[i]))
                {
                    list[i] = ToLower(list[i]);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (char letter in list)
            {
                sb.Append(letter);
            }
            string res = sb.ToString();
        }

        private static bool isLower(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        private static bool isUpper(char c)
        {
            return (c >= 'A' && c <= 'Z');
        }

        public static char ToLower(char c)
        {
            return (char)(c + ('a' - 'A'));
        }

        public static char ToUpper(char c)
        {
            return (char)(c - ('a' - 'A'));
        }
    }
}
