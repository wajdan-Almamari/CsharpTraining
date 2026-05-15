using System.ComponentModel.DataAnnotations;

namespace ClinicManagement_System_CMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── REGION 1: System Storage ───────────────────────────────────── 
            // Capacity constants 
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;

            // Patient slots 
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
            int patientCount = 0;


            // Doctor slots 
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
            int doctorCount = 0;

            // Appointment slots 
            string a1Patient = ""; string a1Doctor = ""; string a1Date = "";
            string a1Status = ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = "";
            string a2Status = ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = "";
            string a3Status = ""; bool a3Active = false; int appointmentCount = 0;
            // ── REGION 2: Main Menu   ───────────────────────────────────── 
            bool backToMain = false;
            while (backToMain == false)
            {
                {


                    Console.WriteLine(" ╔══════════════════════════════════════╗");
                    Console.WriteLine(" ║     CLINIC MANAGEMENT SYSTEM         ║");
                    Console.WriteLine(" ║══════════════════════════════════════╣");
                    Console.WriteLine(" ║  1. Patient Management               ║");
                    Console.WriteLine(" ║  2. Doctor Management                ║");
                    Console.WriteLine(" ║  3. Appointment Management           ║");
                    Console.WriteLine(" ║  0. Exit                             ║");
                    Console.WriteLine(" ╚══════════════════════════════════════╝");
                    Console.Write(" Enter your choice: ");

                    int EnterChoise = Convert.ToInt32(Console.ReadLine());

                    switch (EnterChoise)
                    {
                        //1. Patient Management
                        case 1:
                            bool backToMainP = false;
                            while (backToMainP== false)
                            {
                                Console.WriteLine(" ╔══════════════════════════════════════╗");
                                Console.WriteLine(" ║       PATIENT MANAGEMENT             ║");
                                Console.WriteLine(" ║══════════════════════════════════════╣");
                                Console.WriteLine(" ║ 1. Add New Patient                   ║");
                                Console.WriteLine(" ║ 2. Display All Patients              ║");
                                Console.WriteLine(" ║ 3. Update Patient Phone              ║");
                                Console.WriteLine(" ║ 4. Delete Patient                    ║");
                                Console.WriteLine(" ║ 0. Back to Main Men                  ║");
                                Console.WriteLine(" ╚══════════════════════════════════════╝");
                                Console.Write(" Enter your choice: ");

                                int EnterChoiseP = Convert.ToInt32(Console.ReadLine());

                                switch (EnterChoiseP)
                                {
                                    //1. Add New Patient 
                                    case 1:

                                        // bool choise = false;
                                        //while (choise == false)

                                        Console.WriteLine("1.Add New Patient");
                                        if (patientCount == MAX_PATIENTS)
                                        {
                                            Console.WriteLine("Clinic is full. Cannot add more patients.");

                                        }
                                        else
                                        {
                                            Console.Write("Enter your Name :  ");
                                            string name = Console.ReadLine();
                                            if (name == "")
                                            {
                                                Console.WriteLine("error, Name cannot be empty. ");
                                            }
                                            else
                                            {
                                                Console.Write("Enter your Age:  ");
                                                int age = Convert.ToInt32(Console.ReadLine());
                                                if (age < 1 || age > 120)
                                                {
                                                    Console.WriteLine("error..Invalid age ");
                                                }
                                                else
                                                {
                                                    Console.Write("Enter your Phone:  ");
                                                    string phone = Console.ReadLine();
                                                    if (!p1Active)
                                                    {
                                                        p1Name = name;
                                                        p1Age = age;
                                                        p1Phone = phone;
                                                        p1Active = true;
                                                    }
                                                    else if (!p2Active)
                                                    {
                                                        p2Name = name;
                                                        p2Age = age;
                                                        p2Phone = phone;
                                                        p2Active = true;
                                                    }
                                                    else if (!p3Active)
                                                    {
                                                        p3Name = name;
                                                        p3Age = age;
                                                        p3Phone = phone;
                                                        p3Active = true;
                                                    }

                                                    patientCount++;
                                                    Console.WriteLine("Patient added successfully");

                                                    Console.WriteLine("Enter any key to clear");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                            }
                                        }

                                        break;

                                    //2. Display All Patients  
                                    case 2:
                                        if (patientCount == 0)
                                        {
                                            Console.WriteLine("No patients registered");

                                        }
                                        else
                                        {


                                            int displayNum = 1;
                                            if (p1Active)
                                            {

                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Patient #" + displayNum);
                                                Console.WriteLine("Name : " + p1Name);
                                                Console.WriteLine("Age : " + p1Age);
                                                Console.WriteLine("Phone : " + p1Phone);
                                                displayNum++;


                                            }
                                            if (p2Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Patient #" + displayNum);
                                                Console.WriteLine("Name : " + p2Name);
                                                Console.WriteLine("Age : " + p2Age);
                                                Console.WriteLine("Phone : " + p2Phone);
                                                displayNum++;

                                            }
                                            if (p3Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Patient #" + displayNum);
                                                Console.WriteLine("Name : " + p3Name);
                                                Console.WriteLine("Age : " + p3Age);
                                                Console.WriteLine("Phone : " + p3Phone);
                                                displayNum++;
                                            }


                                        }

                                        break;
                                    //3. Update Patient Phone
                                    case 3:
                                        Console.Write("Enter Patient Name to update phone:  ");
                                        string Pname = Console.ReadLine();
                                        if (p1Active && p1Name == Pname)
                                        {
                                            Console.WriteLine("Current Phone: " + p1Phone);
                                            Console.Write("Enter new phone number:  ");
                                            string newPhone = Console.ReadLine();
                                            p1Phone = newPhone;
                                            Console.WriteLine("Updated");
                                        }
                                        else if (p2Active && p2Name == Pname)
                                        {
                                            Console.WriteLine("Current Phone: " + p2Phone);
                                            Console.Write("Enter new phone number:  ");
                                            string newPhone = Console.ReadLine();
                                            p2Phone = newPhone;         
                                            Console.WriteLine("Updated");
                                        }
                                        else if (p3Active && p3Name == Pname)
                                        {
                                            Console.WriteLine("Current Phone: " + p3Phone);
                                            Console.Write("Enter new phone number:  ");
                                            string newPhone = Console.ReadLine();
                                            p3Phone = newPhone;
                                            Console.WriteLine("Updated");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Patient not found.");
                                        }

                                        break;
                                    //4. Delete Patient
                                    case 4:
                                        Console.Write("Enter Patient Name to delete: ");
                                        string deleteName = Console.ReadLine();
                                        if (p1Active && p1Name == deleteName)
                                        {
                                            p1Active = false;
                                            p1Name = "";
                                            p1Age = 0;
                                            p1Phone = "";
                                            patientCount--;
                                            Console.WriteLine("Patient deleted.");

                                        }
                                        else if (p2Active && p2Name == deleteName)
                                        {
                                            p2Active = false;
                                            p2Name = "";
                                            p2Age = 0;
                                            p2Phone = "";
                                            patientCount--;
                                            Console.WriteLine("Patient deleted.");
                                        }
                                        else if (p3Active && p3Name == deleteName)
                                        {
                                            p3Active = false;
                                            p3Name = "";
                                            p3Age = 0;
                                            p3Phone = "";
                                            patientCount--;
                                            Console.WriteLine("Patient deleted.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Patient not found");
                                        }
                                            break;
                                    //0. Back to Main Menu 
                                    case 0:
                                        backToMainP = true;
                                        break;

                                }//End switch 
                            }//end of while
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            break;
                        // 2.Doctor Management
                        case 2:

                            Console.WriteLine(" ╔══════════════════════════════════════╗");
                            Console.WriteLine(" ║       DOCTOR MANAGEMENT              ║");
                            Console.WriteLine(" ║══════════════════════════════════════╣");
                            Console.WriteLine(" ║ 1. Add New Doctor                    ║");
                            Console.WriteLine(" ║ 2. Display All Doctors               ║");
                            Console.WriteLine(" ║ 3. Update Consultation Fee           ║");
                            Console.WriteLine(" ║ 4. Delete Doctor                     ║");
                            Console.WriteLine(" ║ 0. Back to Main Men                  ║");
                            Console.WriteLine(" ╚══════════════════════════════════════╝");
                            Console.Write(" Enter your choice: ");
                            int EnterChoiseD = Convert.ToInt32(Console.ReadLine());

                            break;
                        //3.Appointment Management
                        case 3:
                            Console.WriteLine(" ╔══════════════════════════════════════╗");
                            Console.WriteLine(" ║       APPOINTMENT MANAGEMENT         ║");
                            Console.WriteLine(" ║══════════════════════════════════════╣");
                            Console.WriteLine(" ║ 1. Book New Appointment              ║");
                            Console.WriteLine(" ║ 2. Display All Appointments          ║");
                            Console.WriteLine(" ║ 3. Update Appointment Status         ║");
                            Console.WriteLine(" ║ 4. Cancel Appointment                ║");
                            Console.WriteLine(" ║ 0. Back to Main Men                  ║");
                            Console.WriteLine(" ╚══════════════════════════════════════╝");
                            Console.Write(" Enter your choice: ");
                            int EnterChoiseA = Convert.ToInt32(Console.ReadLine());

                            break;
                        //0.Exit
                        case 0:
                            backToMain = true;

                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                            Console.Clear();

                            break;

                    }//EndSwitch
                   
                }
            }
        }
    }
}
