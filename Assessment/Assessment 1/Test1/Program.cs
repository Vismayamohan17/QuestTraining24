using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    internal class Program
    {
        static List<string> Departments = new List<string> { "Cardiology", "Pediatrics", "Neurology", "Emergency" };
        static Dictionary<string, string> Doctors = new Dictionary<string, string>
            {
                {"Ajith","Pediatrics"},
                {"Mathews","Neurology" },
                {"Vishnu","Emergency"},
                {"Swapna","Cardiology" }
            };
        static Dictionary<string, Dictionary<string, string>> Patients = new Dictionary<string, Dictionary<string, string>>
            {
                { "Ajith",new Dictionary<string,string>
                    {
                        { "Arjun","Admitted"},
                        {"Amrutha","Not Admitted"}
                    }
                },


                { "Mathews",new Dictionary<string, string>
                    {
                        {"Ramesh","Not Admitted"},
                        {"Latha","Admitted" },
                        {"Albin","Admitted" }
                    }
                },

                { "Vishnu" , new Dictionary<string, string>
                    {
                        {"Rahul","Admitted"},
                        {"Devika","Admitted"},
                        {"Sona","Not Admitted"},
                        {"Anandhu","Admitted"}
                    }

                },

                {"Swapna",new Dictionary<string , string>
                    {
                        {"Remya","Not Admitted"},
                        {"John","Admitted"}
                    }
                }
            };
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Hospital Management System");

                Console.WriteLine("1.Add department and doctor");
                Console.WriteLine("2.Admit Patient");
                Console.WriteLine("3.Doctors in a department.");
                Console.WriteLine("4.Patients assigned to a doctor.");
                Console.WriteLine("5.Discharge Patient");
                Console.WriteLine("6.Exit");
                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddDepartmentAndDoctor();
                        break;
                    case 2:
                        AdmitPatient();
                        break;
                    case 3:
                        DoctorsInDepartment();
                        break;
                    case 4:
                        PatientsAssignedToDoctor();
                        break;
                    case 5:
                        DischargePatient();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        public static void AddDepartmentAndDoctor()
        {
            Console.Write("Enter the new department: ");
            string newDepartment = Console.ReadLine();

            if (!Departments.Contains(newDepartment))
            {
                Departments.Add(newDepartment);
                Console.WriteLine($"Department '{newDepartment}' added successfully.");
            }
            else
            {
                Console.WriteLine($"Department '{newDepartment}' already exists.");

            }
            Console.Write("Enter doctor's name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter the department for the doctor: ");
            string doctorDepartment = Console.ReadLine();


            if (!Doctors.ContainsKey(Name))
            {
                if (Departments.Contains(doctorDepartment))
                {
                    Doctors.Add(Name, doctorDepartment);
                    Console.WriteLine($"Doctor '{Name}' added to department '{doctorDepartment}'.");
                }
                else
                {
                    Console.WriteLine($"Department '{doctorDepartment}' does not exist.");
                }
            }
            else
            {
                Console.WriteLine($"Doctor '{Name}' already exists.");
            }
        }
        public static void AdmitPatient()
        {
            Console.Write("Enter doctors name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter patient name: ");
            string patientName = Console.ReadLine();
            Console.Write("Enter department name: ");
            string departmentName = Console.ReadLine();

            if (Doctors.ContainsKey(Name))
            {
                Console.Write("Enter status of patient: ");
                string status = Console.ReadLine();
                if (!Patients[Name].ContainsKey(patientName))
                {
                    Patients[Name].Add(patientName, status);
                    Console.WriteLine($"Patient '{patientName}' admitted under doctor '{Name}'.");
                }
                else
                {
                    Console.WriteLine($"Patient '{patientName}' is already assigned to doctor '{Name}'.");
                }


            }
        }

        public static void DoctorsInDepartment()
        {
            Console.Write("Enter a department: ");
            string department = Console.ReadLine();

            if (Doctors.ContainsKey(department))
            {
                foreach (var doctor in Doctors)
                {
                    Console.WriteLine($"Doctors in this {department} are {Doctors}");
                }
            }
            else
            {
                Console.WriteLine($"No doctor exist in this department {department}");
            }

        }

        public static void PatientsAssignedToDoctor()
        {
            Console.Write("Enter doctor's name: ");
            string Name = Console.ReadLine();

            if (Doctors.ContainsKey(Name))
            {
                if (Patients.ContainsKey(Name))
                {
                    foreach (var patient in Patients)
                    {
                        Console.WriteLine($"Patient Name:{patient.Key}, Status:{patient.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("No patients assigned.");
                }
            }
            else
            {
                Console.WriteLine($"Doctor '{Name}' does not exist.");
            }
        }

        public static void DischargePatient()
        {
            Console.Write("Enter doctor's name: ");
            string Name = Console.ReadLine();

            if (Doctors.ContainsKey(Name) && Patients.ContainsKey(Name))
            {
                Console.Write("Enter patient's name: ");
                string patientName = Console.ReadLine();

                if (Patients[Name].ContainsKey(patientName))
                {
                    string status = "Not Admitted";
                    Console.WriteLine($"Patient '{patientName}' has been discharged.");
                }
                else
                {
                    Console.WriteLine($"Patient '{patientName}' does not exist under doctor '{Name}'.");
                }
            }
            else
            {
                Console.WriteLine($"Doctor '{Name}' does not exist.");
            }
        }
    }
}
