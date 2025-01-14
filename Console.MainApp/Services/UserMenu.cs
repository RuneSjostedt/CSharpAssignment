

using Business.Factories;
using Business.Models;
using System.Transactions;

namespace MainApp.Services;

public class UserMenu
{
    private readonly UserService _userService = new UserService();

   
    public void Startup()
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
                    CreateOption();
                    break;

                case "2":
                    ViewOption();
                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    InvalidOption();
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

        Console.Write("Enter your Adress: ");
        userRegistrationForm.Adress = Console.ReadLine()!;

        Console.Write("Enter your Postal code: ");
        userRegistrationForm.Postalcode = Console.ReadLine()!;

        Console.Write("Enter your County: ");
        userRegistrationForm.County = Console.ReadLine()!;

        bool result  = _userService.Create(userRegistrationForm);

        if (result)
            OutputDialog("Contact was succesfully created");
        else
            OutputDialog("Contact was not created sucessfully");
    }

    public void ViewOption()
    {
        Console.Clear();
        
        Console.Readkey();
    }

    public void InvalidOption()
    {
        Console.Clear();
        Console.WriteLine("Invalid selection. Try again");
        Console.ReadKey();
    }
    
    public void OutputDialog(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.ReadKey();
    }


}




