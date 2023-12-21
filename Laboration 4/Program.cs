using System;

namespace Laboration_4
{
    internal class Program



    {
        public static List<Person> personList = new List<Person>();
        
        static void Main(string[] args)
        {
           

            while (true)
            {
                Console.WriteLine(
                "\nChoose from the menubar below and type in the associated number to access it" +
                "\n" +
                "\n----------------------------------------------------------------------------" +
                "\n1 - Add person." +
                "\n" +
                "\n2 - Let the program print a list of all admitted people." +
                "\n" +
                "\n3 - Exit the program." +
                "\n-----------------------------------------------------------------------------" +
                "\n"
                );

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPerson(); //Anropar metoden för att lägga till en person


                        break;

                    case 2:
                        ListPersons(); //Anropar metoden för att visa tillagda personer


                        break;

                    case 3:
                        Console.WriteLine("\nPress anywhere to exit the program"); // Avslutar programmet

                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1-3: ");
                        break;

                }
            }
        }

        
        
        
        // Metod för att lägga till en person i personList
       static void AddPerson()
        {
            // Deklarerar variabler för användarinputen
            Gender InputGender = Gender.Male;
            Hair InputHair = new Hair();
            DateTime InputDateTime = DateTime.Now;
            string InputEyecolor = "";
            int PickGender = 0;

            
            
            bool WrongInput = false;
            // Loop för att hantera data om kön med felhantering
            do
            {
                try
                {
                    Console.WriteLine("How does the person identify?\n1: Male\n2: Women\n3: NonBinary\n4: Other");
                    PickGender = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    WrongInput = false;

                if (PickGender <= 0||PickGender >= 5)
                    {
                        throw new Exception();
                    }

                }
                catch
                {
                    {
                        Console.WriteLine("Invalid input: Please enter a number between 1-4: ");
                        WrongInput = true;
                    }
                    
                }
            } while (WrongInput == true);

            
            // Switch-sats för att tilldela kön baserat på användaren
            switch (PickGender)
            {
                case 1:
                    InputGender = Gender.Male;
                    break;

                case 2:
                    InputGender = Gender.Women;
                    break;

                case 3:
                    InputGender = Gender.NonBinary;
                    break;

                case 4:
                    InputGender = Gender.Other;
                    break;
            }
            
            
            // Loop för att hantera födelsedag med felhantering
            bool BirthdayError = false;
            do
            {
                try
                {
                    Console.WriteLine("\nPlease enter birthday of the person. The only valid format is YYYY-MM-DD: ");
                    InputDateTime = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    BirthdayError = false;
                }
                catch
                {
                    Console.WriteLine("\nInvalid input. Please use the format YYYY-MM-DD: ");
                    BirthdayError = true;
                }

            } while (BirthdayError == true);

            
            // Loop för att hantera hårlängd med felhantering
            bool HairLengthError = false;
            do
            {
                try
                {
                    Console.WriteLine("\nEnter hair length: ");
                    InputHair.Hairlength = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    HairLengthError = false;
                }
                catch 
                { 
                    Console.WriteLine("\nInvalid input. Please use numbers only: ");
                    HairLengthError = true;
                }

            }while (HairLengthError == true);
            
            // Loop för att hantera hårfärg med felhantering
            bool HairColorError = false;
            do
            {
                try
                {
                    Console.WriteLine("\nPlease enter hair color: ");
                    InputHair.Haircolor = Console.ReadLine();
                    Console.WriteLine("");
                    HairColorError = false;

                    if (InputHair.Haircolor.Any(Char.IsDigit))
                    {
                        throw new Exception();
                    }
                }
                catch 
                {
                    Console.WriteLine("\nInvalid input. Please enter a color using letters only: ");
                    HairColorError = true;
                }
                
            }while (HairColorError == true);

           
            // Loop för att hantera ögonfärg med felhantering
            bool EyecolorInputError = false;
            do
            {
                try
                {
                    Console.WriteLine("\nPlease enter eye color: ");
                    InputEyecolor = Console.ReadLine();
                    Console.WriteLine("");
                    EyecolorInputError = false;

                    if (InputEyecolor.Any(Char.IsDigit))
                    {
                        throw new Exception();
                    }

                }
                catch
                {
                    Console.WriteLine("\nInvalid input. Please enter an eye color with letters only: ");
                    EyecolorInputError = true;
                }

            } while (EyecolorInputError == true);
            


            // skapar ett nytt Person-objekt och lägger till det i personList
            Person person = new Person(InputGender, InputHair, InputEyecolor, InputDateTime);
            personList.Add(person);
        }


        // Metod för att lista alla personer i personList
      static void ListPersons()
        {
            Console.WriteLine("All the added persons: ");

            // Vi itererar genom listan och skriver ut information om varje person

            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString() + "\n");
            }
        }
    }

}