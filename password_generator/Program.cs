using FormationCS;
using System;

namespace password_generator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            const int NUMBER_OF_PASSWORD = 10;
            //1 - ask password length by creating a module that we can use after because it's a function that we ask a lot
            int passWordLength = outils.AskPositiveNumber("What is the password lenght ? ");

            // You would like a password with :
            // 1 - Only minus
            // 2 - Only minus and capital
            // 3 - Only alphabet and number
            // 4 - alphabet, number and special character
            int passwordType = outils.AskNumberBetweenMinAndMax("You would like a password with: \n" +
                "1 - Only minus \n" +
                "2 - Only minus and capital \n" +
                "3 - Only alphabet and number \n" +
                "4 - Alphabet, number and special character\n" +
                "Your choice: ", 1, 4);
            Console.WriteLine("Choose your password: ");
            Console.WriteLine("");

            string minus = "abcdefghijklmnopqrstuvwxyz";
            string capital = minus.ToUpper();
            string number = "0123456789";
            string specialCharacter = "#$_-&+*/";
            string alphabet;

            switch (passwordType)
            {
                case 1:
                    alphabet = minus;
                    break;
                case 2:
                    alphabet = minus + capital;
                    break;
                case 3:
                    alphabet = minus + capital + number;
                    break;
                default:
                    alphabet = minus + capital + number + specialCharacter;
                    break;
            }
            //2 - create an alphabet
            //3 - choose a random character
            
            for(int j=0; j<NUMBER_OF_PASSWORD; j++)
            {
            string password = "";
            int l = alphabet.Length;
            Random rand = new Random();

            for(int i=0; i<passWordLength; i++)
            {
                int index = rand.Next(0, l);
                password += alphabet[index];
            }


            
            Console.WriteLine(password);
            }
            



            //4 - generate the password  
            //5 - FEATURE : choose the kind a password needed
        }
    }
}
