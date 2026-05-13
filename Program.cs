using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace BankingServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int accountNumber = 0;
            string holderName = "";
            double balance = 0.00;
            bool isActive = false;
            char accountType = ' ';
            bool isEmployed = false;
            double salary = 0.00;
            int creditScore = 0;
            int age = 0;
            double deposit = 0.00;
            double withdrawal = 0.00;
            double annualRate = 0.00;
            double avgBalance = 0.00;

            //system options
            //dispay main Menu
            Console.WriteLine("=== SYSTEM SETUP  —  Enter Account & Customer Data ===");
            Console.WriteLine("--- Account Profile ---");
            Console.WriteLine("1)  Account Number       (int)    current: 0");
            Console.WriteLine("2) Holder Name          (string) current: [not set]");
            Console.WriteLine("3)  Balance              (double) current: 0.000 OMR");
            Console.WriteLine("4)  Account Active?      (bool)   current: false   [enter 1=yes / 0=no]");
            Console.WriteLine("5)  Account Type         (char)   current: -       [enter S / C / F] ");
            Console.WriteLine("--- Customer Profile -- ");
            Console.WriteLine("6)  Employed?            (bool)   current: false   [enter 1=yes / 0=no]");
            Console.WriteLine("7)  Monthly Salary       (double) current: 0.000 OMR ");
            Console.WriteLine("8)  Credit Score         (int)    current: 0");
            Console.WriteLine("9)  Age                  (int)    current: 0");
            Console.WriteLine("--- Transaction Data -");
            Console.WriteLine("10) Last Deposit Amount  (double) current: 0.000 OMR");
            Console.WriteLine("11) Last Withdrawal      (double) current: 0.000 OMR");
            Console.WriteLine("12) Annual Interest Rate (double) current: 0.000   [e.g. 0.035 = 3.5%]");
            Console.WriteLine("13) Avg Monthly Balance  (double) current: 0.000 OMR");
            Console.WriteLine("0)  Setup complete — launch Main Menu");


            int setupChoice = -1;

            while (setupChoice != 0)
            {
                Console.Write("Select option: ");
                setupChoice = int.Parse(Console.ReadLine());

                switch (setupChoice)
                {
                    case 1:
                        Console.Write("Enter Account Number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account Number Saved.");
                        break;

                    case 2:
                        Console.Write("Enter Holder Name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder Name Saved.");
                        break;

                    case 3:
                        Console.Write("Enter Balance: ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance Saved.");
                        break;

                    case 4:
                        Console.Write("Enter 1=active / 0=inactive: ");
                        isActive = int.Parse(Console.ReadLine()) == 1;
                        Console.WriteLine("Account Status Saved.");
                        break;

                    case 5:
                        Console.Write("Enter Account Type S / C / F: ");
                        accountType = char.Parse(Console.ReadLine().ToUpper());
                        Console.WriteLine("Account Type Saved.");
                        break;

                    case 6:
                        Console.Write("Enter 1=employed / 0=not employed: ");
                        isEmployed = int.Parse(Console.ReadLine()) == 1;
                        Console.WriteLine("Employment Status Saved.");
                        break;

                    case 7:
                        Console.Write("Enter Monthly Salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Salary Saved.");
                        break;

                    case 8:
                        Console.Write("Enter Credit Score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("Credit Score Saved.");
                        break;

                    case 9:
                        Console.Write("Enter Age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Age Saved.");
                        break;

                    case 10:
                        Console.Write("Enter Last Deposit Amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Deposit Saved.");
                        break;

                    case 11:
                        Console.Write("Enter Last Withdrawal Amount: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Withdrawal Saved.");
                        break;

                    case 12:
                        Console.Write("Enter Annual Interest Rate: ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Annual Rate Saved.");
                        break;

                    case 13:
                        Console.Write("Enter Average Monthly Balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Average Balance Saved.");
                        break;

                    case 0:
                        Console.WriteLine("Setup complete. Launching Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1–13 or 0.");
                        break;
                }


            }//End while loop

            // -------------------------------------------------------------------------------------------------------------------------
            // MAIN MENU

            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("NATIONAL BANK OF OMAN  —  Unified Banking System");
                Console.WriteLine("Main MENU ");

                Console.WriteLine("1) ATM Services");
                Console.WriteLine("2) Account Management");
                Console.WriteLine("3) Loan Services");
                Console.WriteLine("4) Currency Exchange");
                Console.WriteLine("5) Credit Card Portal");
                Console.WriteLine("6) Branch Services");
                Console.WriteLine("7) Reports & Admin");
                Console.WriteLine("0) Exit");


                Console.Write("Select Module: ");
                choice = int.Parse(Console.ReadLine());

                //switch option 
                switch (choice)
                {

                    // ATM Services
                    case 1:

                        Console.WriteLine("\n=== ATM SERVICES === ");

                        Console.WriteLine("1) Bank Info");
                        Console.WriteLine("2) View Account Data");
                        Console.WriteLine("3) PIN Validation");
                        Console.WriteLine("4) Receipt Printer");
                        Console.WriteLine("0) Back To Main Menu");

                        Console.Write("Select: ");
                        int atmChoice = int.Parse(Console.ReadLine());

                        switch (atmChoice)
                        {

                            // TASK 2 -> ATM Welcome & Display

                            case 1:
                                Console.WriteLine("=== ATM SERVICES === ");
                                Console.WriteLine("1) Bank Info");
                                Console.WriteLine("2) Branch Info");
                                Console.WriteLine("3) Opening Hours");
                                Console.WriteLine("0) Back To Main Menu");
                                Console.Write("Select: ");
                                int atmChoice1 = int.Parse(Console.ReadLine());
                                switch (atmChoice1)
                                {

                                    case 1:// Bank Information
                                        Console.WriteLine("National Bank Of Oman");
                                        Console.WriteLine("Your Trusted Banking Partner");
                                        Console.WriteLine(" Founding Year: 1973");
                                        break;
                                    case 2:// Branch Information
                                        Console.WriteLine("Muscat branch name ");
                                        Console.WriteLine(" city: Muscat");
                                        Console.WriteLine(" address: Sultan Qaboos Street");
                                        break;
                                    case 3:// Opening Hours
                                        Console.WriteLine("Weekdays: 8 AM - 3 PM");

                                        Console.WriteLine("Weekend: Closed");
                                        break;

                                    case 0:// Back To Main Menu
                                        Console.WriteLine("Returning to Main Menu...");
                                        break;
                                    default:
                                        Console.WriteLine("'Invalid selection. Please try again.");
                                        break;
                                }

                                break;


                            // TASK 3 -> Account Data Viewer
                            case 2:

                                Console.WriteLine("\n=== VIEW ACCOUNT DATA ===");
                                Console.WriteLine("Data loaded from system setup");

                                Console.WriteLine("1) Account Number");
                                Console.WriteLine("2) Holder Name");
                                Console.WriteLine("3) Balance");
                                Console.WriteLine("4) Status");
                                Console.WriteLine("5) Account Type");
                                Console.WriteLine("0) Back");

                                Console.Write("Select field: ");
                                int dataChoice = int.Parse(Console.ReadLine());


                                switch (dataChoice)
                                {

                                    case 1:
                                        Console.WriteLine("Account Number: " + accountNumber);
                                        break;

                                    case 2:
                                        Console.WriteLine("Holder Name: " + holderName);
                                        break;

                                    case 3:
                                        Console.WriteLine("Balance: " + balance + "  OMR");
                                        break;

                                    case 4:
                                        Console.WriteLine("Account Status: " + isActive);
                                        break;

                                    case 5:
                                        Console.WriteLine("Account Type: " + accountType);
                                        break;

                                    case 0:
                                        Console.WriteLine("Returning...");
                                        break;

                                    default:
                                        Console.WriteLine("Field not available.");
                                        break;
                                }

                                break;


                       
                            case 3: // TASK 4 -> ATM PIN Validation
                                Console.WriteLine("=== AUTHENTICATION ===");

                                const string CORRECT_PIN = "4821";
                                const int MAX_ATTEMPTS = 3;

                                Console.WriteLine("1) Enter PIN");
                                Console.WriteLine("2) Forgot PIN");
                                Console.WriteLine("0) Back");

                                Console.Write("Select: ");
                                int PINServices = int.Parse(Console.ReadLine());

                                switch (PINServices)
                                {

                                    case 1: // Enter PIN

                                        int attempts = 0;

                                        while (attempts < MAX_ATTEMPTS)
                                        {
                                            Console.Write("Enter PIN: ");
                                            string enterPin = Console.ReadLine();

                                            if (enterPin == CORRECT_PIN)
                                            {
                                                Console.WriteLine("Access granted. Welcome " + holderName);
                                                break;
                                            }

                                            else if (enterPin.Length != 4)
                                            {
                                                Console.WriteLine("Invalid PIN format.");
                                            }

                                            else
                                            {
                                                Console.WriteLine("Incorrect PIN.");
                                            }

                                            attempts++;

                                        }

                                        break;


                                    case 2: // Forgot PIN

                                        Console.WriteLine("Please visit the nearest branch with your National ID.");
                                        break;


                                    case 0: // Back

                                        Console.WriteLine("Returning to ATM Services...");
                                        break;


                                    default:

                                        Console.WriteLine("Invalid selection. Please try again.");
                                        break;
                                }

                                break;



                            case 4: // TASK 5 -> ATM Receipt Printer

                                Console.WriteLine("=== PRINT RECEIPT ===");
                                Console.WriteLine("1) Short Receipt");
                                Console.WriteLine("2) Detailed Receipt");
                                Console.WriteLine("3) Balance Only");
                                Console.WriteLine("0) Back");

                                Console.Write("Select format: ");
                                int enterReceipt = int.Parse(Console.ReadLine());

                                switch (enterReceipt)
                                {

                                    case 1: // Short Receipt

                                        string accountText = accountNumber.ToString();

                                        Console.WriteLine("=== SHORT RECEIPT ===");
                                        Console.WriteLine("Holder  : " + holderName);
                                        Console.WriteLine("Account : " + accountText.Substring(accountText.Length - 4));
                                        Console.WriteLine("Balance : " + balance + " OMR");

                                        break;

                                    case 2: // Detailed Receipt

                                        Console.WriteLine("=== DETAILED RECEIPT ===");
                                        Console.WriteLine("Account Number : " + accountNumber);
                                        Console.WriteLine("Holder Name    : " + holderName);
                                        Console.WriteLine("Balance        : " + balance + " OMR");
                                        Console.WriteLine("Account Active : " + isActive);
                                        Console.WriteLine("Account Type   : " + accountType);
                                        Console.WriteLine("Employed       : " + isEmployed);
                                        Console.WriteLine("Monthly Salary : " + salary + " OMR");
                                        Console.WriteLine("Credit Score   : " + creditScore);
                                        Console.WriteLine("Age            : " + age);
                                        Console.WriteLine("Deposit Amount : " + deposit + " OMR");
                                        Console.WriteLine("Withdrawal     : " + withdrawal + " OMR");
                                        Console.WriteLine("Annual Rate    : " + annualRate);
                                        Console.WriteLine("Average Balance: " + avgBalance + " OMR");

                                        break;


                                    case 3: // Balance Only

                                        Console.WriteLine("=== BALANCE ONLY ===");

                                        Console.WriteLine("Current Balance: " + balance + " OMR");

                                        break;


                                    case 0: // Back

                                        Console.WriteLine("Returning to ATM Services...");
                                        break;


                                    default: // Invalid Receipt Format

                                        Console.WriteLine("Invalid receipt format.");
                                        break;
                                }

                                break;


                            // Back To Main Menu
                            case 0:

                                Console.WriteLine("Returning To Main Menu...");
                                break;


                            // Invalid ATM Selection
                            default:

                                Console.WriteLine("Invalid selection. Please try again.");
                                break;
                        }

                        break;


                    // Account Management
                    case 2:

                        Console.WriteLine("Account Management");
                        break;


                    // Loan Services
                    case 3:

                        Console.WriteLine("Loan Services");
                        break;


                    // Currency Exchange
                    case 4:

                        Console.WriteLine("Currency Exchange");
                        break;


                    // Credit Card Portal
                    case 5:

                        Console.WriteLine("Credit Card Portal");
                        break;


                    // Branch Services
                    case 6:

                        Console.WriteLine("Branch Services");
                        break;


                    // Reports & Admin
                    case 7:

                        Console.WriteLine("Reports & Admin");
                        break;


                    // Exit Program
                    case 0:

                        Console.WriteLine("Thank you for using National Bank Of Oman.");
                        break;


                    // Invalid Main Menu Selection
                    default:

                        Console.WriteLine("Invalid Number");
                        break;

                }
            }

        }

    }
}
            




