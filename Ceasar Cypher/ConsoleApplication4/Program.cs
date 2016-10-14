            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApplication4
    {
        using System;

        class MainClass
        {
            public static void Main()
            {

            // Start with no user string
                string UserString = null;
                int shift;
                Shift WORDSHIFT = new Shift();
                Console.WriteLine("Ceasar Cypher:");

                Console.WriteLine("type a string to encrypt:");

                UserString = Console.ReadLine();




                Console.WriteLine("How many characters would you like to shift: :");

                shift = int.Parse(Console.ReadLine());

                Console.Write("Your encrypted string is: ");

                Console.WriteLine(WORDSHIFT.Cshift(UserString, shift));
                Console.Read();
            }
        }

        class Shift
        {
            public string Cshift(string str, int shift)
            {
                string UserOutput = null;
                char[] A = null;
                A = str.ToCharArray();
                int temp;

                for (int i = 0; i < str.Length; i++)
                {
                    temp = (int) (A[i] + shift);
                    UserOutput += (char) temp;
                }
                return UserOutput;
            }

        }
    }