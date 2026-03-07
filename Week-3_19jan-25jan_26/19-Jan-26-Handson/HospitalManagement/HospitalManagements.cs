using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement
{
    internal class HospitalManagements
    {

        // Base class
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        // Derived classes
        class Patient : Person
        {
            public int Age { get; set; }
        }

        class Doctor : Person
        {
            public string Specialization { get; set; }
        }

        class Nurse : Person
        {
            public string Shift { get; set; }
        }

        // Appointment class
        class Appointment
        {
            public Patient Patient { get; set; }
            public Doctor Doctor { get; set; }
            public DateTime Date { get; set; }

            public void ShowDetails()
            {
                Console.WriteLine($"Patient: {Patient.Name}");
                Console.WriteLine($"Doctor: {Doctor.Name}");
                Console.WriteLine($"Date: {Date}");
            }
        }

        // Encapsulation for medical records
        class MedicalRecord
        {
            private string medicalHistory;

            public void SetHistory(string history)
            {
                medicalHistory = history;
            }

            public string GetHistory()
            {
                return medicalHistory;
            }
        }

        class Program
        {
            static void Main()
            {
                Patient p1 = new Patient { Id = 1, Name = "Amit", Age = 30 };
                Doctor d1 = new Doctor { Id = 101, Name = "Dr. Mehta", Specialization = "Cardiology" };

                Appointment ap = new Appointment
                {
                    Patient = p1,
                    Doctor = d1,
                    Date = DateTime.Now
                };

                MedicalRecord record = new MedicalRecord();
                record.SetHistory("Blood Pressure Problem");

                ap.ShowDetails();
                Console.WriteLine("Medical History: " + record.GetHistory());

                Console.ReadLine();
            }
        }
    }
}
