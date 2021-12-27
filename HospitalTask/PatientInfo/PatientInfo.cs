using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalTask.ImplementInterfaces;
using static System.Console;
using System.IO;
using System.Text.Encodings;


namespace HospitalTask.PatientInfo
{
    public class PatientInfo: IPatientInfo
    {

        public string PatientName { get ; set ; }
        public string PatientType { get ; set ; }
        public string PatientSurname { get ; set ; }
        public string PatientBirthday { get ; set ; }

        public void AddPatient()
        {
            while (true)
            {
                WriteLine("Patient name entering: ");
                PatientName = ReadLine();

                WriteLine("Patient surname entering: ");
                PatientSurname = ReadLine();

                WriteLine("Patient Birthday entering: ");
                PatientBirthday = ReadLine();

                WriteLine("Patient illness type entering: ");
                PatientType = ReadLine();

                // Bu yerda qabul qilib olingan ma'lumotlar faylga yozilyabdi
                WriteToFiile(PatientName, PatientSurname, PatientBirthday, PatientType);
                Clear();

                WriteLine("Is there patient again? [y/n] ");
                string identify = ReadLine();

                if (identify.ToLower() == "n") {
                    WiewPatientInfo();
                    break;
                }
                

            }

        } 

        static void WriteToFiile(string PatientName, string PatientSurname, string PatientBirthday, string PatientType)
        {

            string path = @"D:\HospitalPatientDB\PatientDb.txt";

            IEnumerable<string> AllData = new List<string>() { PatientName + ", " + PatientSurname + ", " + PatientBirthday + ", " + PatientType + "\n" };

            File.AppendAllLines(path, AllData);
        }

        static void WiewPatientInfo()
        {
            string path = @"D:\HospitalPatientDB\PatientDb.txt";

            IEnumerable<string> readAllText = File.ReadAllLines(path);
            foreach (string line in readAllText)
            {
                WriteLine(line);
            }
        }
    }
}
