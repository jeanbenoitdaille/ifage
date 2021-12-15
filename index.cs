    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
           public static string CheckAge(int age)
            {
                // Ne pas toucher cette ligne.
                string message = "";
                
                
                if(age < 18) {
                    message = "Vous êtes mineur(e)";
                } else if (age < 20) {
                    message = "Vous êtes tout juste majeur(e)";
                } else {
                    message = "Vous êtes majeur(e)";
                }
                
                // Ne pas toucher ces lignes.
                Console.WriteLine(message);
                return message;
            }
        }
    }