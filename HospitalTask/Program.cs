using System;
using HospitalTask.PatientInfo;

namespace HospitalTask.PatientInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PatientInfo patientInfo = new PatientInfo();

            patientInfo.AddPatient();
              


        }
    }
}
