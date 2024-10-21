using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_Management
{
    class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string medicalcondition { get; set; }
    };

    class Appointment
    {
        public int id { get; set; }
        public int patientid { get; set; }
        public string doctorName { get; set; }
        public DateTime Date { get; set; }

        public string type { get; set; }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            var Patients = new List<Patient>()
            {
               new Patient { id = 1, name = "John Doe", age = 45, gender = "Male", medicalcondition = "Hypertension" },
               new Patient { id = 2, name = "Jane Smith", age = 34, gender = "Female", medicalcondition = "Diabetes" },
               new Patient { id = 3, name = "Alex Johnson", age = 29, gender = "Male", medicalcondition = "Asthma" },
               new Patient { id = 4, name = "Emily Davis", age = 54, gender = "Female", medicalcondition = "Arthritis" },
               new Patient { id = 5, name = "Michael Brown", age = 60, gender = "Male", medicalcondition = "Heart Disease" },
               new Patient { id = 6, name = "Linda Wilson", age = 49, gender = "Female", medicalcondition = "Thyroid Disorder" },
               new Patient { id = 7, name = "David Garcia", age = 38, gender = "Male", medicalcondition = "Migraine" },
               new Patient { id = 8, name = "Sarah Lee", age = 25, gender = "Female", medicalcondition = "Allergies" },
               new Patient { id = 9, name = "Robert White", age = 70, gender = "Male", medicalcondition = "Parkinson's Disease" },
               new Patient { id = 10, name = "Jessica King", age = 31, gender = "Female", medicalcondition = "Anxiety" }
            };

            var Appointments = new List<Appointment>()
            {
                 new Appointment { id = 1, patientid = 1, doctorName = "Dr. Adams", Date = new DateTime(2024, 10, 25), type = "Checkup" },
                 new Appointment { id = 2, patientid = 2, doctorName = "Dr. Baker", Date = new DateTime(2024, 10, 26), type = "Follow-up" },
                 new Appointment { id = 3, patientid = 3, doctorName = "Dr. Clark", Date = new DateTime(2024, 10, 27), type = "Consultation" },
                 new Appointment { id = 4, patientid = 4, doctorName = "Dr. Adams", Date = new DateTime(2024, 10, 28), type = "Checkup" },
                 new Appointment { id = 5, patientid = 5, doctorName = "Dr. Evans", Date = new DateTime(2024, 10, 29), type = "Consultation" },
                 new Appointment { id = 6, patientid = 6, doctorName = "Dr. Baker", Date = new DateTime(2024, 10, 30), type = "Follow-up" },
                 new Appointment { id = 7, patientid = 7, doctorName = "Dr. Clark", Date = new DateTime(2024, 10, 31), type = "Checkup" },
                 new Appointment { id = 8, patientid = 8, doctorName = "Dr. Adams", Date = new DateTime(2024, 11, 1), type = "Consultation" },
                 new Appointment { id = 9, patientid = 9, doctorName = "Dr. Evans", Date = new DateTime(2024, 11, 2), type = "Checkup" },
                 new Appointment { id = 10, patientid = 10, doctorName = "Dr. Baker", Date = new DateTime(2024, 11, 3), type = "Follow-up" }
            };
            //first query
            var result = Appointments.Where(a => a.Date <= DateTime.Now.AddDays(7));

            var details = Appointments
                .Where(a => a.Date <= DateTime.Now.AddDays(7))
                .Join(
                    Patients,
                    a => a.patientid,
                    p => p.id,
                    (a, p) => new
                    {
                        Name = p.name,
                        age = p.age,
                        medicalcondition = p.medicalcondition
                    }
                );
            foreach (var Patient in details)
            {
                Console.WriteLine($"Name:{Patient.Name},age:{Patient.age},medicalcondition:{Patient.medicalcondition}");
            }

            //second query
            var groups = Patients.GroupBy(p => p.medicalcondition);
            foreach (var Group in groups)
            {
                Console.WriteLine($"{Group.Key} - {Group.Count()}");
            }

            //Fourth query
            var output = Patients.Where(p => p.age > 60)
                .Join(
                    Appointments,
                    p => p.id,
                    a => a.patientid,
                    (p, a) => new
                    {
                        Name = p.name,
                        DoctorsName = a.doctorName,
                        Date = a.Date,
                        type = a.type,
                    }
                );
            foreach (var Patient in output)
            {
                Console.WriteLine($"PatientName:{Patient.Name},DoctorsName:{Patient.DoctorsName},Date:{Patient.Date},Type:{Patient.type}");
            }



        }
    }
}
