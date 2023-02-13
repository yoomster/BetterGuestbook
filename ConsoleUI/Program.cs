using GuestBookLibrary;
using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// capture info about each guest
// like FirstName, LastName, Info to Host
// one done, loop through each guest and print their info


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> people = new List<GuestModel>();
           
            UserMessages.Welcome();

            UserQuestions.AskFirstName(people);

            UserMessages.ShowAllMessages(people);


            Console.ReadLine();
        }
    }
}
