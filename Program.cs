using System;

namespace NumbersGame4._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isRunnung = true;
            while (isRunnung)
            {
                CheckGuess();



                Console.WriteLine("Vill du spela igen ? svara gärna med Ja eller Nej");
                string svar = Console.ReadLine().ToUpper();
                if (svar == "JA")
                {
                    Console.Clear();
                }
                else
                {
                    isRunnung = false;
                }
            }

        }


        static void CheckGuess()
        {


            Console.WriteLine("Hej välkommen till NumbersGame va vänlig välj svårighetsgrad");
            Console.WriteLine("1:Easy   1-10");
            Console.WriteLine("2:Normal 1-20");
            Console.WriteLine("3:Hard   1-30");
            int UserChoice = 0;
            Random rnd = new Random();
            int EasyNum = rnd.Next(1, 11);
            int NormalNum = rnd.Next(1, 21);
            int HardNum = rnd.Next(1, 31);
            bool T = true;
            int result = 0;

            while (T) // bool is true but if bool turn false then the loop end
            {
                UserChoice = int.Parse(Console.ReadLine());

                if (UserChoice >= 1 && UserChoice <= 3) // Check if the user chose number between 1-3 if so then make T = false and loop closed 
                {
                    T = false;
                }
                else
                {
                    Console.WriteLine("Vänligen skriv ett tal mellan 1-3");
                }
            }


            switch (UserChoice) 
            {
                case 1:
                    result = EasyNum;
                    Console.WriteLine("Du valde Easy 1 - 10");
                    break;
                case 2:
                    result = NormalNum;
                    Console.WriteLine("Du valde Normal 1 - 20");
                    break;
                case 3:
                    result = HardNum;
                    Console.WriteLine("Du valde Hard 1 - 30");
                    break;


            }




            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            for (int i = 0; i < 5; i++) // 5 times to play start from 0
            {
                Console.WriteLine("Svar:");
                string InputText = Console.ReadLine();// Reading userinput
                int InputNum = Int32.Parse(InputText);// Convert InputText to numbervalue
                if (InputNum < result)// If input is lower then right answer
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");// InputNum is lower then rndNum then give a clue
                }
                else if (InputNum > result)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!"); // InputNum is higher then rndNum then give a clue
                }
                else
                {
                    Console.WriteLine($"Woho! Du gjorde det! {result} är rätt nummer!"); // If given right answer then tell the user
                    break;
                }


                if (i == 4)// Tell me when i is = 5 start from 0,1,2,3,4 
                {
                    Console.WriteLine($"Tyvärr du lyckades inte gissa talet på fem försök och talet är {result}");

                }
            }



        }
    }
}
