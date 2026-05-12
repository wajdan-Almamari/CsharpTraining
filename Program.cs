using System.Diagnostics;

namespace BankingServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int accountNumber =0;
            string holderName= "";
            double balance = 0.00;
            bool isActive= false;
            char accountType ;
            bool isEmployed= false;
            double salary =0.00;
            int creditScore =0 ;
            int age =0 ;
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
            }


        }
    }
    }
