using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDMIS.Models
{
    public class Home
    {
    }

    public class PatientExport
    {
        public string HealthCoachId { get; set; }
        public string HealthCoachName { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string HUserId { get; set; }
        public string HospitalCode { get; set; }
        public string HospitalName { get; set; }
    }
}