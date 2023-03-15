using System;

namespace AddressBook
{
    public class AddressBookMain
    {
        Contact Contacts = new Contact();
        public void addcontact()
        {
            Console.WriteLine("Enter First Name");
            Contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enetr Last Name");
            Contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            Contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            Contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            Contacts.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            Contacts.Zip = Console.ReadLine();
            Console.WriteLine("Enetr Phone NUmber");
            Contacts.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            Contacts.Email = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("First name: " + Contacts.FirstName + "\nLastname: " + Contacts.LastName + "\nAddress: " + Contacts.Address +
                "\nCity: " + Contacts.City + "\nState: " + Contacts.State + "\nZIP: " + Contacts.Zip + "\nPhone Number: " + Contacts.PhoneNumber + "\nEmail: " + Contacts.Email);
        }
    }
}