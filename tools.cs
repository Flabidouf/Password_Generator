using System;



    namespace FormationCS
    {
        public class tools
        {
            
           
                public static int AskNumberPositive(string question)
                {
                   /* int positiveNumber = AskNumber(question);

                    if (positiveNumber > 0)
                    {
                        return positiveNumber;
                    }
                    Console.WriteLine("Error, number must be positive");

                    return AskNumberPositive(question);*/

                   // ou :

                     return AskNumberBetween(question, 1, int.MaxValue, "Error: The number must be positive");
                }



                public static int AskNumberBetween(string question, int min, int max, string personnalisedErrorMsg = null)
                { // On ajoute un paramètre personnalisedErrorMsg afin d'ajouter un string
                  // en paramètre quand on reprend la fonction ailleurs.
                    int number = AskNumber(question);

                    if ((number >= min) && (number <= max))
                    {
                        return number;
                    }

                    if (personnalisedErrorMsg == null)
                    {
                        Console.WriteLine("Error, number must be between " + min + " and " + max);
                    }
                    else
                    {
                        Console.WriteLine(personnalisedErrorMsg);
                    }

                    Console.WriteLine();
                    
                    return AskNumberBetween(question, min, max, personnalisedErrorMsg); 
                    // Demander à Max ce que fait le return ici, le return retourne la fonction vers où ? 
                    // Pourquoi fait-on ça ?
                    
                }
                
                

                static int AskNumber(string question)
                {

                    while (true)
                    {
                        Console.WriteLine(question);
                        string answer = Console.ReadLine();

                        try
                        {
                            int answerInt = int.Parse(answer);
                            return answerInt;

                        }
                        catch
                        {
                            Console.WriteLine("Error, enter a valid number.");
                            Console.WriteLine();
                        }

                    }
                }
            
        }
    }

