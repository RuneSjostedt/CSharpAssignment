

using Business.Factories;
using Business.Models;
using System.Transactions;

namespace MainApp.Services;

public class UserMenu
{
    static void Main(string[] args)
    {
        bool exit = false;  

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=====Contactlist Menu=====");
            Console.WriteLine("1. Create a Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Exit");
            Console.WriteLine("===========================");
            Console.Write("Choose an Option: ");

            String userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Try again");
                    break;
            }
        }
    }
    public void CreateOption()
    {

        UserRegistrationForm userRegistrationForm = UserFactory.Create();
       
        Console.Clear();

        Console.Write("Enter your first name: ");
        userRegistrationForm.FirstName = Console.ReadLine()!;

        Console.Write("Enter your last name: ");
        userRegistrationForm.LastName = Console.ReadLine()!;

        Console.Write("Enter your Email: ");
        userRegistrationForm.Email = Console.ReadLine()!;

        Console.Write("Enter your Phonenumber ");
        userRegistrationForm.Phonenumber = Console.ReadLine()!;

        Console.Write("Enter your first name: ");
        userRegistrationForm.Adress = Console.ReadLine()!;

        Console.Write("Enter your first name: ");
        userRegistrationForm.Postalcode = Console.ReadLine()!;

        Console.Write("Enter your first name: ");
        userRegistrationForm.County = Console.ReadLine()!;

        Console.ReadKey();
    }

    public void ViewOption()
    {
        Console.Clear();



        Console.Readkey();
    }
}




