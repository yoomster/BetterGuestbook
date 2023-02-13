using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary
{
    public class UserQuestions
    {
        public static void AskFirstName(List <GuestModel> people)
        {
            string firstName;
            do
            {
                Console.Write("Please enter your first name (or type 'exit' to stop): ");
                firstName = Console.ReadLine();

                if (firstName != "exit")
                {
                    GuestModel person = new GuestModel();
                    person.FirstName = firstName;
                    person.LastName = AskLastName();

                    people.Add(person);

                    person.MessageToHost = AskMessage();

                    Console.WriteLine();
                } 
            } while (firstName != "exit");
        }

        public static string AskLastName()
        {
            Console.Write("And your last name: ");
            string lastName = Console.ReadLine();

            return lastName;
        }

        public static string AskMessage()
        {
            Console.Write("If you like, you may leave a message for your host here: ");
            string message = Console.ReadLine();

            return message;
        }
    }
}
