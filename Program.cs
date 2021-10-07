using System;

namespace LanguageConverter
{
    class Program
            //1 Prompt user to enter a language 
            //2 Display Hellp World for that language 
            //3 Use a Switch Statement 
            //4 Would you like to continue y/n? 
    {
        static void Main(string[] args)

        {
            bool goOn = true; 
            while (goOn)
            {

            Console.Write("Enter a language: ");
            string language = Console.ReadLine();

            switch (language)
                {
                case "English":
                    Console.WriteLine("Hello World");
                    break;
                case "Spanish":
                    Console.WriteLine("Hola Mundo");
                    break;
                case "French":
                    Console.WriteLine("Bonjour le monde");
                    break;
                case "German":
                    Console.WriteLine("Hallo Welt");
                    break;
                case "Portuguese":
                    Console.WriteLine("Ola Mundo");
                    break; 

                }

                Console.WriteLine("Continue? (y/n)");


                string name1 = Console.ReadLine();

                if (name1 == "Y" || name1 == "y")
                {
                    goOn = true;
                }
                else
                {
                    goOn = false;
                    Console.WriteLine($"Goodbye! Hace a Nice day!!");
                    continue;
                }

            }

            
        }
    }
}
