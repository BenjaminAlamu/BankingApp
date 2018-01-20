using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace My_Banking_App
{
    /// <summary>
    /// The Customer Class
    /// Everything about the Customer is stored here
    /// </summary>
    public class Customer
    {

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name of the customer.
        /// </value>
        private string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name of the customer.
        /// </value>
        private string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the other.
        /// </summary>
        /// <value>
        /// The other name of the customer
        /// </value>
        private string OtherName { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address of the customer.
        /// </value>
        private string Address { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number of the customer.
        /// </value>
        private string PhoneNum { get; set; }

        /// <summary>
        /// Gets or sets the next of kin.
        /// </summary>
        /// <value>
        /// The name of the  next of kin of the customer.
        /// </value>
        private string NextOfKin { get; set; }

        /// <summary>
        /// Gets or sets the next of kin address.
        /// </summary>
        /// <value>
        /// The next of kin address of the customer.
        /// </value>
        private string NextOfKinAddress { get; set; }

        /// <summary>
        /// Gets or sets the nextof kin phone number.
        /// </summary>
        /// <value>
        /// The next of kin phone number.
        /// </value>
        private string NextofKinPhoneNum { get; set; }

        /// <summary>
        /// Gets or sets the day of birth.
        /// </summary>
        /// <value>
        /// The day of birth customer.
        /// </value>
        private int DayOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the month of birth .
        /// </summary>
        /// <value>
        /// The month of birth customer.
        /// </value>
        private String MonthOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the year of birth.
        /// </summary>
        /// <value>
        /// The year of birth of the customer.
        /// </value>
        public int YearOfBirth { get; set; }


        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        public Customer()
        {
            //A constructor that gets data from the user
            Console.WriteLine("Welcome to CSC 322 Bank\nToday is the first time we are meeting and you are required to answer a few questions so we can know you better\nEnter your first name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter your middle name");
            OtherName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            PhoneNum = Console.ReadLine();
            Console.WriteLine("Enter the name of your next of Kin");
            NextOfKin = Console.ReadLine();
            Console.WriteLine("Enter the address of your next of Kin");
            NextOfKinAddress = Console.ReadLine();
            Console.WriteLine("Enter the phone number of your next of Kin");
            NextofKinPhoneNum = Console.ReadLine();
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Enter your day of birth e.g '7' or '23'");
                try
                {
                    DayOfBirth = Int32.Parse(Console.ReadLine());
                    cont = false;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Please enter a numeric value: ");
                }
            }
            
            Console.WriteLine("Enter your month of birth: ");
            MonthOfBirth = Console.ReadLine();
            cont = true;


            while (cont)
            {
                Console.WriteLine("Enter your year of birth: ");
                try
                {
                    YearOfBirth = Int32.Parse(Console.ReadLine());
                    cont = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a numeric value: ");
                }
            }


        }

        /// <summary>
        /// Gets the customer details.
        /// </summary>
        public void getCustomerDetails()
        {
            //Printing the details of the customer
            Console.WriteLine("Name: " + FirstName+ " " + LastName + " " + OtherName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone Number "+ PhoneNum);
            Console.WriteLine("Name of Next Of Kin : " +NextOfKin);
            Console.WriteLine("Address of Next of Kin: " + NextOfKinAddress);
            Console.WriteLine("Phone number of Next of Kin: " + NextofKinPhoneNum);
            Console.WriteLine("Date of Birth: " + DayOfBirth + " " + MonthOfBirth + " " + YearOfBirth);
        }

        /// <summary>
        /// Updates the customer details.
        /// </summary>
        public void UpdateCustomerDetails()
        {
            //A method that updates which ever part of the Customer's details, the customer wishes to update
            String input;
            Console.WriteLine("Hello, which of your details would you want to update");
            Console.WriteLine("Please pick the corresponding number to what you want to change");
            Console.WriteLine("First Name - 1\nLast Name - 2\nOther Name - 3\nAddress - 4\nPhone Number - 5\nNext Of Kin - 6\nNext of Kin Address - 7\nNext of Kin Phone Number -8\nDay of Birth - 9\nMonth of Birth - 10\n Year of Birth -11\nTo Quit Menu -12");
            input =Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Kindly enter your new First Name: ");
                FirstName = Console.ReadLine();
            }
            else if (input == "2")
            {
                Console.WriteLine("Kindly enter your new Last Name: ");
                LastName = Console.ReadLine();
            }
            else if (input == "3")
            {
                Console.WriteLine("Kindly enter your new Other Name: ");
                OtherName = Console.ReadLine();
            }
            else if (input == "4")
            {
                Console.WriteLine("Kindly enter your new Address: ");
                Address = Console.ReadLine();
            }
            else if (input == "5")
            {
                Console.WriteLine("Kindly enter your new Phone Number: ");
                PhoneNum = Console.ReadLine();
            }
            else if (input == "6")
            {
                Console.WriteLine("Kindly enter your new Next of Kin: ");
                NextOfKin = Console.ReadLine();
            }
            else if (input == "7")
            {
                Console.WriteLine("Kindly enter your new Next of Kin Address: ");
                NextOfKinAddress = Console.ReadLine();
            }
            else if (input == "8")
            {
                Console.WriteLine("Kindly enter your new Next of Kin Phone Number: ");
                NextofKinPhoneNum = Console.ReadLine();
            }
            else if (input == "9")
            {
                bool cont = true;
                while (cont)
                {
                    Console.WriteLine("Enter your day of birth e.g '7' or '23'");
                    try
                    {
                        DayOfBirth = Int32.Parse(Console.ReadLine());
                        cont = false;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please enter a numeric value: ");
                    }
                }
            }
            else if(input == "10")
            {
                Console.WriteLine("Enter your month of Birth");
                MonthOfBirth = Console.ReadLine();
            }
            else if (input == "11")
            {
                bool cont = true;
                while (cont)
                {
                    Console.WriteLine("Enter your year of Birth");
                    try
                    {
                        DayOfBirth = Int32.Parse(Console.ReadLine());
                        cont = false;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please enter a numeric value: ");
                    }
                }
            }
            else if(input == "12")
            {
                Console.WriteLine("You just quit the update details menu");
            }
            else
            {
                Console.WriteLine("Invalid input. Pls try again");
            }
            Console.WriteLine("Here are your updated details");
            getCustomerDetails();
        }




    }
}
