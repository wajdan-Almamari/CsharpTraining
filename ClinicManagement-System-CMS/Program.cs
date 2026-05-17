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
            //bool backToMain = false;
            //while (backToMain == false)
            while (true)
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
                           // bool backToMainP = false;
                           // while (backToMainP == false)
                           while (true)
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
                                        //backToMainP = true;
                                        break;

                                }//End switch 
                                Console.WriteLine("Press Enter to continue...");
                                Console.ReadLine();
                            }//end of while

                            break;
                        // 2.Doctor Management
                        case 2:
                            bool backToMainD = false;
                            while (backToMainD == false)
                            {
                                Console.WriteLine(" ╔══════════════════════════════════════╗");
                                Console.WriteLine(" ║       DOCTOR MANAGEMENT              ║");
                                Console.WriteLine(" ║══════════════════════════════════════╣");
                                Console.WriteLine(" ║ 1. Add New Doctor                    ║");
                                Console.WriteLine(" ║ 2. Display All Doctors               ║");
                                Console.WriteLine(" ║ 3. Update Consultation Fee           ║");
                                Console.WriteLine(" ║ 4. Delete Doctor                     ║");
                                Console.WriteLine(" ║ 0. Back to Main Menu                 ║");
                                Console.WriteLine(" ╚══════════════════════════════════════╝");
                                Console.Write(" Enter your choice: ");
                                int EnterChoiseD = Convert.ToInt32(Console.ReadLine());
                                switch (EnterChoiseD)
                                {
                                    //1. Add New Doctor
                                    case 1:
                                        Console.WriteLine("1.Add New Doctor");
                                        Console.WriteLine("═════════════════════════════════════");
                                        if (doctorCount == MAX_DOCTORS)
                                        {
                                            Console.WriteLine("No available doctor slots");
                                        }
                                        else
                                        {

                                            Console.Write("Enter Doctor Name : ");
                                            string Dname = Console.ReadLine();
                                            if (Dname == "")
                                            {
                                                Console.WriteLine("Error..Name cannot be empty");
                                            }
                                            else
                                            {
                                                Console.Write("Enter Doctor Specialization: ");
                                                string spec = Console.ReadLine();
                                                if (spec == "")
                                                {
                                                    Console.WriteLine("Error..Specialization cannot be empty");
                                                }
                                                else
                                                {
                                                    Console.Write("Enter Consultation Fee: ");

                                                    double fee = Convert.ToDouble(Console.ReadLine());
                                                    if (fee < 0)
                                                    {
                                                        Console.WriteLine("Error..Invalid fee");
                                                    }
                                                    else
                                                    {
                                                        if (!d1Active)
                                                        {
                                                            d1Name = Dname;
                                                            d1Spec = spec;
                                                            d1Fee = fee;
                                                            d1Active = true;
                                                        }
                                                        else if (!d2Active)
                                                        {
                                                            d2Name = Dname;
                                                            d2Spec = spec;
                                                            d2Fee = fee;
                                                            d2Active = true;
                                                        }
                                                        Console.WriteLine("Doctor added successfully");
                                                        doctorCount++;
                                                        Console.WriteLine("Enter any key to clear");
                                                        Console.ReadLine();
                                                        Console.Clear();
                                                    }
                                                }

                                            }
                                        }

                                        break;
                                    //2. Display All Doctors
                                    case 2:


                                        Console.WriteLine("2. Display All Doctors");
                                        Console.WriteLine("═════════════════════════════════════");

                                        if (doctorCount == 0)
                                        {
                                            Console.WriteLine("No doctors registered.");
                                        }

                                        else
                                        {
                                            int displayNum = 1;

                                            if (d1Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Doctor #" + displayNum);
                                                Console.WriteLine("Name : " + d1Name);
                                                Console.WriteLine("Specialization : " + d1Spec);
                                                Console.WriteLine("Consultation Fee : " + d1Fee);

                                                displayNum++;
                                            }

                                            if (d2Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Doctor #" + displayNum);
                                                Console.WriteLine("Name : " + d2Name);
                                                Console.WriteLine("Specialization : " + d2Spec);
                                                Console.WriteLine("Consultation Fee : " + d2Fee);

                                                displayNum++;
                                            }
                                        }

                                        break;

                                    //3. Update Consultation Fee
                                    case 3:

                                        Console.Write("Enter Doctor Name to update fee: ");
                                        string doctorName = Console.ReadLine();

                                        if (d1Active && d1Name == doctorName)
                                        {
                                            Console.Write("Enter New Consultation Fee: ");
                                            double newFee = Convert.ToDouble(Console.ReadLine());

                                            if (newFee < 0)
                                            {
                                                Console.WriteLine("Invalid fee.");
                                            }

                                            else
                                            {
                                                d1Fee = newFee;

                                                Console.WriteLine("Fee updated.");
                                            }
                                        }

                                        else if (d2Active && d2Name == doctorName)
                                        {
                                            Console.Write("Enter New Consultation Fee: ");
                                            double newFee = Convert.ToDouble(Console.ReadLine());

                                            if (newFee < 0)
                                            {
                                                Console.WriteLine("Invalid fee.");
                                            }

                                            else
                                            {
                                                d2Fee = newFee;

                                                Console.WriteLine("Fee updated.");
                                            }
                                        }

                                        else
                                        {
                                            Console.WriteLine("Doctor not found.");
                                        }

                                        break;
                                    //4. Delete Doctor
                                    case 4:
                                        Console.WriteLine("4.Delete Doctor");
                                        Console.WriteLine("═════════════════════════════════════");
                                        Console.Write("Enter Doctor Name to delete: ");
                                        string deleteDoctor = Console.ReadLine();

                                        if (d1Active && d1Name == deleteDoctor)
                                        {
                                            d1Active = false;
                                            d1Name = "";
                                            d1Spec = "";
                                            d1Fee = 0;

                                            doctorCount--;

                                            Console.WriteLine("Doctor removed.");
                                        }

                                        else if (d2Active && d2Name == deleteDoctor)
                                        {
                                            d2Active = false;
                                            d2Name = "";
                                            d2Spec = "";
                                            d2Fee = 0;

                                            doctorCount--;

                                            Console.WriteLine("Doctor removed.");
                                        }

                                        else
                                        {
                                            Console.WriteLine("Doctor not found.");
                                        }

                                        break;


                                    //0. Back to Main Menu
                                    case 0:
                                        backToMainD = true;
                                        break;
                                }
                                Console.WriteLine("Press Enter to continue...");
                                Console.ReadLine();
                            }//end of while
                            break;
                        //3.Appointment Management
                        case 3:
                            bool backToMainA = false;

                            while (backToMainA == false)
                            {
                            Console.WriteLine(" ╔══════════════════════════════════════╗");
                            Console.WriteLine(" ║       APPOINTMENT MANAGEMENT         ║");
                            Console.WriteLine(" ║══════════════════════════════════════╣");
                            Console.WriteLine(" ║ 1. Book New Appointment              ║");
                            Console.WriteLine(" ║ 2. Display All Appointments          ║");
                            Console.WriteLine(" ║ 3. Update Appointment Status         ║");
                            Console.WriteLine(" ║ 4. Cancel Appointment                ║");
                            Console.WriteLine(" ║ 0. Back to Main Menu                 ║");
                            Console.WriteLine(" ╚══════════════════════════════════════╝");
                            Console.Write(" Enter your choice: ");
                            int EnterChoiseA = Convert.ToInt32(Console.ReadLine());
                                switch (EnterChoiseA)
                                {
                                    //1. Book New Appointment
                                    case 1:
                                        Console.WriteLine("1.Book New Appointment");
                                        Console.WriteLine("═════════════════════════════════════");
                                        if (appointmentCount == MAX_APPOINTMENTS)
                                        {
                                            Console.WriteLine("No available appointment slots.");

                                        }
                                        else if (patientCount == 0 || doctorCount == 0)
                                        {
                                            Console.WriteLine("Please add patients and doctors first");

                                        }
                                        else
                                        {

                                            Console.WriteLine("Choose Patient:");

                                            if (p1Active)
                                                Console.WriteLine("1. " + p1Name);

                                            if (p2Active)
                                                Console.WriteLine("2. " + p2Name);
                                            if (p3Active)
                                                Console.WriteLine("3. " + p3Name);

                                            Console.Write("Enter patient choice: ");
                                            int patientChoice = Convert.ToInt32(Console.ReadLine());
                                            string chosenPatient = "";

                                            if (patientChoice == 1 && p1Active)
                                            {
                                                chosenPatient = p1Name;
                                            }
                                            else if (patientChoice == 2 && p2Active)
                                            {
                                                chosenPatient = p2Name;
                                            }
                                            else if (patientChoice == 3 && p3Active)
                                            {
                                                chosenPatient = p3Name;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid patient choice.");
                                            }

                                            if (chosenPatient != "")
                                            {
                                                Console.WriteLine("Choose Doctor:");

                                                if (d1Active) Console.WriteLine("1. " + d1Name);
                                                if (d2Active) Console.WriteLine("2. " + d2Name);

                                                Console.Write("Enter doctor choice: ");
                                                int doctorChoice = Convert.ToInt32(Console.ReadLine());

                                                string chosenDoctor = "";

                                                if (doctorChoice == 1 && d1Active)
                                                {
                                                    chosenDoctor = d1Name;
                                                }
                                                else if (doctorChoice == 2 && d2Active)
                                                {
                                                    chosenDoctor = d2Name;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid doctor choice.");
                                                }

                                                if (chosenDoctor != "")
                                                {
                                                    Console.Write("Enter appointment date DD/MM/YYYY: ");
                                                    string date = Console.ReadLine();

                                                    if (a1Active && a1Patient == chosenPatient && a1Doctor == chosenDoctor && a1Date == date)
                                                    {
                                                        Console.WriteLine("Duplicate appointment.");
                                                    }
                                                    else if (a2Active && a2Patient == chosenPatient && a2Doctor == chosenDoctor && a2Date == date)
                                                    {
                                                        Console.WriteLine("Duplicate appointment.");
                                                    }
                                                    else if (a3Active && a3Patient == chosenPatient && a3Doctor == chosenDoctor && a3Date == date)
                                                    {
                                                        Console.WriteLine("Duplicate appointment.");
                                                    }
                                                    else
                                                    {
                                                        if (!a1Active)
                                                        {
                                                            a1Patient = chosenPatient;
                                                            a1Doctor = chosenDoctor;
                                                            a1Date = date;
                                                            a1Status = "Scheduled";
                                                            a1Active = true;
                                                        }
                                                        else if (!a2Active)
                                                        {
                                                            a2Patient = chosenPatient;
                                                            a2Doctor = chosenDoctor;
                                                            a2Date = date;
                                                            a2Status = "Scheduled";
                                                            a2Active = true;
                                                        }
                                                        else if (!a3Active)
                                                        {
                                                            a3Patient = chosenPatient;
                                                            a3Doctor = chosenDoctor;
                                                            a3Date = date;
                                                            a3Status = "Scheduled";
                                                            a3Active = true;
                                                        }

                                                        appointmentCount++;
                                                        Console.WriteLine("Appointment booked.");
                                                    }
                                                }
                                            }
                                        }

                                        break;
                                    //2. Display All Appointments
                                    case 2:

                                        Console.WriteLine("2. Display All Appointments");
                                        Console.WriteLine("═════════════════════════════════════");

                                        if (appointmentCount == 0)
                                        {
                                            Console.WriteLine("No appointments booked.");
                                        }

                                        else
                                        {
                                            int displayNum = 1;

                                            if (a1Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Appointment #" + displayNum);
                                                Console.WriteLine("Patient : " + a1Patient);
                                                Console.WriteLine("Doctor : " + a1Doctor);
                                                Console.WriteLine("Date : " + a1Date);
                                                Console.WriteLine("Status : " + a1Status);

                                                displayNum++;
                                            }

                                            if (a2Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Appointment #" + displayNum);
                                                Console.WriteLine("Patient : " + a2Patient);
                                                Console.WriteLine("Doctor : " + a2Doctor);
                                                Console.WriteLine("Date : " + a2Date);
                                                Console.WriteLine("Status : " + a2Status);

                                                displayNum++;
                                            }

                                            if (a3Active)
                                            {
                                                Console.WriteLine("═════════════════════════════════════");
                                                Console.WriteLine("Appointment #" + displayNum);
                                                Console.WriteLine("Patient : " + a3Patient);
                                                Console.WriteLine("Doctor : " + a3Doctor);
                                                Console.WriteLine("Date : " + a3Date);
                                                Console.WriteLine("Status : " + a3Status);

                                                displayNum++;
                                            }
                                        }

                                        break;
                                    //3. Update Appointment Status
                                    case 3:


                                        Console.WriteLine("3. Update Appointment Status");
                                        Console.WriteLine("═════════════════════════════════════");

                                        if (appointmentCount == 0)
                                        {
                                            Console.WriteLine("No appointments booked.");
                                        }

                                        else
                                        {
                                            if (a1Active)
                                            {
                                                Console.WriteLine("1. " + a1Patient + " - " + a1Doctor + " - " + a1Date);
                                            }

                                            if (a2Active)
                                            {
                                                Console.WriteLine("2. " + a2Patient + " - " + a2Doctor + " - " + a2Date);
                                            }

                                            if (a3Active)
                                            {
                                                Console.WriteLine("3. " + a3Patient + " - " + a3Doctor + " - " + a3Date);
                                            }

                                            Console.Write("Choose appointment slot: ");
                                            int slotChoice = Convert.ToInt32(Console.ReadLine());

                                            if ((slotChoice == 1 && a1Active) ||
                                                (slotChoice == 2 && a2Active) ||
                                                (slotChoice == 3 && a3Active))
                                            {
                                                Console.WriteLine("Choose New Status:");
                                                Console.WriteLine("1. Scheduled");
                                                Console.WriteLine("2. Completed");
                                                Console.WriteLine("3. Cancelled");

                                                int statusChoice = Convert.ToInt32(Console.ReadLine());

                                                switch (statusChoice)
                                                {
                                                    case 1:

                                                        if (slotChoice == 1) a1Status = "Scheduled";
                                                        else if (slotChoice == 2) a2Status = "Scheduled";
                                                        else if (slotChoice == 3) a3Status = "Scheduled";

                                                        break;

                                                    case 2:

                                                        if (slotChoice == 1) a1Status = "Completed";
                                                        else if (slotChoice == 2) a2Status = "Completed";
                                                        else if (slotChoice == 3) a3Status = "Completed";

                                                        break;

                                                    case 3:

                                                        if (slotChoice == 1) a1Status = "Cancelled";
                                                        else if (slotChoice == 2) a2Status = "Cancelled";
                                                        else if (slotChoice == 3) a3Status = "Cancelled";

                                                        break;

                                                    default:
                                                        Console.WriteLine("Invalid status choice.");
                                                        break;
                                                }

                                                Console.WriteLine("Appointment status updated.");
                                            }

                                            else
                                            {
                                                Console.WriteLine("Invalid slot.");
                                            }
                                        }

                                        break;

                                    //4. Cancel Appointment
                                    case 4:

                                        Console.Write("Enter Patient Name: ");
                                        string patientName = Console.ReadLine();

                                        Console.Write("Enter Appointment Date: ");
                                        string cancelDate = Console.ReadLine();

                                    if (a1Active && a1Patient == patientName && a1Date == cancelDate)
                                    {
                                            a1Status = "Cancelled";

                                            Console.WriteLine("Appointment cancelled.");
                                        }

                                        else if (a2Active && a2Patient == patientName && a2Date == cancelDate)
                                    {
                                            a2Status = "Cancelled";

                                            Console.WriteLine("Appointment cancelled.");
                                        }

                                        else if (a3Active && a3Patient == patientName && a3Date == cancelDate)
                                    {
                                            a3Status = "Cancelled";

                                            Console.WriteLine("Appointment cancelled.");
                                        }

                                        else
                                        {
                                            Console.WriteLine("Appointment not found.");
                                        }

                                        break;
                                    //0. Back to Main Menu
                                    case 0:
                                        backToMainA = true;
                                        break;

                                }
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                        }
                            break;
                        //0.Exit
                        case 0:
                        //  backToMain = true;
                        return;

                       // break;
                    default: 
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }//EndSwitch

                }
            }
        }
    }
