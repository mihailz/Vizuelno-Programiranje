using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab144
{
    enum PasswordStrength
    {
        easy,
        normal,
        hard
    }
    class Program
    {

        

        public static string generatePassword(PasswordStrength strength)
        {
            
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            if(strength == PasswordStrength.easy)
            {
                string validChars = "abcdefghijklmnopqrstuvwxyz";
                int numOfChars = rnd.Next(1, 7);
                for(int i=0; i<numOfChars; i++)
                {
                    res.Append(validChars[rnd.Next(0, validChars.Length)]);
                }
            }

            else if (strength == PasswordStrength.normal)
            {
                string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                int numOfChars = rnd.Next(6, 11);
                for (int i = 0; i < numOfChars; i++)
                {
                    res.Append(validChars[rnd.Next(0, validChars.Length)]);
                }
            }

            else 
            {
                string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890~!@#$%^&*()_+{}";
                int numOfChars = rnd.Next(10, 30);
                for (int i = 0; i < numOfChars; i++)
                {
                    res.Append(validChars[rnd.Next(0, validChars.Length)]);
                }
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your guessing with blank space: \n");
            string guess = Console.ReadLine();
            char delimiter = ' ';
            string[] parts = guess.Split(delimiter);
            string easyPass = generatePassword(PasswordStrength.easy);
            string normalPass = generatePassword(PasswordStrength.normal);
            string hardPass = generatePassword(PasswordStrength.hard);
            bool correctGuess = false;
            foreach(string s in parts) 
                if(s.Equals(easyPass) || s.Equals(normalPass) || s.Equals(hardPass))
                {
                    correctGuess = true;
                    break;
                }

            if (correctGuess == true)
            {
                Console.WriteLine("You guessed right.");
            }
            else if (correctGuess == false)
            {
                Console.WriteLine("You did not guessed right, try again for more luck.");
            }
            Console.WriteLine("\nHard password: {0}", hardPass);
            Console.WriteLine("\nNormal password: {0}", normalPass);
            Console.WriteLine("\nEasy password: {0}", easyPass);
            Console.ReadLine();

        }
    }
}
