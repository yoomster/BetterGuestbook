using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary
{
    public static class UserQuestions
    {

        public static string GetInformationFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
        public static int GetNumberFromConsole (string message)
        {
            bool isValidNr;
            int output;
            do
            {
                Console.Write(message);
                string TextNr = Console.ReadLine();
                isValidNr = int.TryParse(TextNr, out output); 
                if (isValidNr == false)
                {
                    Console.WriteLine("That's an invalid nr, plz try again.");
                }
            } while (isValidNr == false);

            return output;

        }

        public static void AskGuestAllInfo(List<GuestModel> guests)
        {
            GuestModel guest = new GuestModel();

            guest.FirstName = GetInformationFromConsole("Please enter your first name: ");
            guest.LastName = GetInformationFromConsole("Please enter your last name: ");
            guest.MessageToHost = GetInformationFromConsole("If you like, you may leave a message for your host here: ");
            guest.Age = GetNumberFromConsole("Please enter your age: ");

            guests.Add(guest);
        }

        public static void AskMorePeopleComing(List<GuestModel> guests)
        {
            string moreGuestComing;
            do
            {
                Console.Write("Is there more guest coming? (yes/no): ");
                moreGuestComing = Console.ReadLine();
                Console.WriteLine();

                if (moreGuestComing == "yes")
                {
                    AskGuestAllInfo(guests);
                } 
            } while (moreGuestComing == "yes");

        }
    }
}
