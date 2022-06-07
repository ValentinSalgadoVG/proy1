using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sustract");
            Console.WriteLine("3. Times");
            Console.WriteLine("4. Divider\n");

            Console.Write("u option: ");
            try
            {
                int op = int.Parse(Console.Read().ToString());
                if (op == 1) suma();
                if (op == 2) resta();
                if (op == 3) multiplicacion();
                if (op == 4) division();
            }
            catch (Exception e)
            {
                Console.WriteLine("So funny.");
            }
        }

        public static void suma()
        {

        }

        public static void resta()
        {

        }

        public static void multiplicacion()
        {

        }

        public static void division()
        {

        }
    }
}
