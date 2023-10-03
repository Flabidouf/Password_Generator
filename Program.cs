using System;
using FormationCS;

namespace Password_Generator
{
    class Program
    {
        /*enum e_Operator //Pas besoin de ça, la fonction AskNumberBetween fait la même chose
        {
            MINUSCULES = 1,
            MIN_MAJ = 2,
            MIN_MAJ_N = 3, 
            MIN_MAJ_N_X = 4
        }*/
       
        static void Main(string[] args)
        {
            
            int nb_Password = tools.AskNumberPositive("How many passwords do you need ?\n" +
                                                      "Your choice : ");
            
            int passwordLength = tools.AskNumberPositive("Length of password : ");
            
            Console.WriteLine();

           
            // On réutilise la fonction AskNumberBetween en donnant à son paramètre précédemment "question",
            // une string avec le message que l'on souhaite avant d'utiliser la fonction.
            int chosenAlphabet = tools.AskNumberBetween("You want a password with :\n" + 
                                                        "1 - Lowercase\n" +
                                                        "2 - Lowercase and uppercase\n" + 
                                                        "3 - Lowercase, uppercase and numbers\n" + 
                                                        "4 - Lowercase, uppercase, numbers and specials\n" + 
                                                        "Your choice : ",1, 4);

            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = lowercase.ToUpper();
            string numbers = "123456789";
            string specialChars = "#&%$-+!";
            string alphabet = lowercase + uppercase + numbers + specialChars;
          
            string passWord = "";       

            Random rand = new Random();

            // Pas d'accolades pcq une seule ligne de code par if 
            if (chosenAlphabet == 1)
                alphabet = lowercase;
            else if (chosenAlphabet == 2)
                alphabet = lowercase + uppercase;
            else if (chosenAlphabet == 3)
                alphabet = lowercase + uppercase + numbers;
            else
                alphabet = lowercase + uppercase + numbers + specialChars;
            
            
            int alphabetLength = alphabet.Length;

            for (int j = 0; j < nb_Password; j++)
            {
                passWord = "";
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = rand.Next(0, alphabetLength); // Pas de l-1 pcq dernière valeur exclue ave .Next
                    passWord += alphabet[index];
                    
                }

                Console.WriteLine("Password = " + passWord);
            }
        }
    }
}

