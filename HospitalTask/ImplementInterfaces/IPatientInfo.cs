using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTask.ImplementInterfaces
{
    public interface IPatientInfo
    {
        public string PatientName { get; set; }
        public string PatientType { get; set; }
        public string PatientSurname { get; set; }
        public string PatientBirthday { get; set; }
    }
}
