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
            bool choiceP = false;
            while (choiceP == false)
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

                int EnterChoise = int.Parse(Console.ReadLine());

                switch (EnterChoise)
                {
                    //1. Patient Management
                    case 1:
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

                        int EnterChoiseP = int.Parse(Console.ReadLine());

                        switch (EnterChoiseP)
                        {
                            //1. Add New Patient 
                            case 1:

                                bool choise = false;
                                while (choise == false)
                                {
                                    Console.WriteLine("1.Add New Patient");
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("Clinic is full. Cannot add more patients.");

                                    }
                                    Console.WriteLine("Enter your Name");
                                    string name = Console.ReadLine();
                                    if (name == " ")
                                    {
                                        Console.WriteLine("error ");
                                    }
                                    Console.WriteLine("Enter your Age");
                                    int age = Convert.ToInt32(Console.ReadLine());
                                    if (age < 1 || age > 120)
                                    {
                                        Console.WriteLine("error ");
                                    }
                                    Console.WriteLine("Enter your Phone");
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
                                }//end of while
                                break;
                            //2. Display All Patients  
                            case 2:
                                if (patientCount == 0)
                                {
                                    Console.WriteLine("No patients registered");
                                    return;
                                }
                                else if (p1Active)
                                {
                                    Console.WriteLine(" p1Name : " + p1Name);
                                    Console.WriteLine(" p1Age : " + p1Age);
                                    Console.WriteLine(" p1Phone : " + p1Phone);
                                }
                                else if (p2Active)
                                {
                                    Console.WriteLine(" p2Name : " + p2Name);
                                    Console.WriteLine(" p2Age : " + p2Age);
                                    Console.WriteLine(" p2Phone : " + p2Phone);
                                }
                                else if (p3Active)
                                {
                                    Console.WriteLine(" p3Name : " + p3Name);
                                    Console.WriteLine(" p3Age : " + p3Age);
                                    Console.WriteLine(" p3Phone : " + p3Phone);
                                }



                                break;
                            //3. Update Patient Phone
                            case 3:

                                Console.WriteLine();
                                break;
                            //4. Delete Patient
                            case 4:
                                Console.WriteLine();
                                break;
                            //0. Back to Main Menu 
                            case 0:
                                Console.WriteLine();
                                break;

                        }//End switch 

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
                        int EnterChoiseD = int.Parse(Console.ReadLine());

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
                        int EnterChoiseA = int.Parse(Console.ReadLine());

                        break;
                    //0.Exit
                    case 0:
                        Console.WriteLine();
                        break;

                }//EndSwitch
            }
        }
    }
}
