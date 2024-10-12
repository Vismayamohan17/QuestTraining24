using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Task_1
{
    internal class Program
    {
            static Dictionary<int, (string Name, int Age, List<string> Symptoms)> patients = new Dictionary<int, (string, int, List<string>)>();
        static void AddPatient(int patientID, string name, int age, List<string> symptoms)
        {
            if (patients.ContainsKey(patientID))
            {
                Console.WriteLine("Patient with this ID already exists.");
            }
            else
            {
                patients[patientID] = (name, age, symptoms);
                Console.WriteLine("Patient added.");
            }
        }
            static void GetPatientInfo(int patientID)
            {
                if (patients.ContainsKey(patientID))
                {
                    var patient = patients[patientID];
                    Console.WriteLine($"Patient ID: {patientID}, Name: {patient.Name}, Age: {patient.Age}, Symptoms: {string.Join(", ", patient.Symptoms)}");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
            static List<int> BySymptom(string symptom)
            {
                List<int> matchingPatients = new List<int>();

                foreach (var patient in patients)
                {
                    if (patient.Value.Symptoms.Contains(symptom))
                    {
                        matchingPatients.Add(patient.Key);
                    }
                }

                return matchingPatients;
            }

            static void Main(string[] args)
            {
                AddPatient(1, "John", 30, new List<string> { "Bodypain", "Fever" });
                AddPatient(2, "David", 45, new List<string> { "Headache", "Cough" });

                GetPatientInfo(1);

                List<int> patientsWithFever = BySymptom("Fever");
                Console.WriteLine("Patients with Fever:");
                foreach (int id in patientsWithFever)
                {
                    Console.WriteLine($"Patient ID: {id}");
                }
            }

    }
}
