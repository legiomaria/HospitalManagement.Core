using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services.Contracts.Patients
{
    public class PatientCreateReq
    {
        public string FirstName { set; get; } = string.Empty;

        public string MiddleName { set; get; } = string.Empty;

        public string LastName { set; get; } = string.Empty;

        public string Address { set; get; } = string.Empty;

        public string Phone { set; get; } = string.Empty;
    }
}
