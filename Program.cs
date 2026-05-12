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

            Console.WriteLine("NATIONAL BANK OF OMAN  —  Unified Banking System");
            Console.WriteLine("Task 1  ->  System Setup (populate all shared variables first)");
          
            Console.WriteLine("1: ATM Services ");
            Console.WriteLine("2: Account Management ");
            Console.WriteLine("3: Loan Services  ");
            Console.WriteLine("4: Currency Exchange");
            Console.WriteLine("5: Credit Card Portal ");
            Console.WriteLine("6: Branch Services ");
            Console.WriteLine("7: Reports & Admin ");
            Console.WriteLine("Select Option");
            int choice =int.Parse(Console.ReadLine());

            //switch option 

            switch(choice){
                case 1: 
                    Console.WriteLine("1: ATM Services ");
                    break;
                case 2:
                    Console.WriteLine("2: Account Management ");
                    break;
                case 3:
                    Console.WriteLine("3: Loan Services  ");
                    break;
                case 4:
                    Console.WriteLine("4: Currency Exchange");
                    break;
                case 5:
                    Console.WriteLine("5: Credit Card Portal ");
                    break;
                case 6:
                    Console.WriteLine("6: Branch Services ");
                    break;
                case 7:
                    Console.WriteLine("7: Reports & Admin ");
                    break;
                defult: 
                    Console.WriteLine("Invalid Number ");
                    break;
            }







        }
    }
}
