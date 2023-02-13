using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary
{
    public class UserMessages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to our party! This is the guestbook, we'd like for you to sign in.");
            Console.WriteLine();
        }

        public static void ShowAllMessages(List<GuestModel> people)
        {
            foreach (GuestModel p in people)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{p.FirstName} {p.LastName} left you the next message: {p.MessageToHost}");
            }
        }

    }
}
