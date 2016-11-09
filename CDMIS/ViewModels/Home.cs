using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDMIS.Models;
using System.Web.Mvc;

namespace CDMIS.ViewModels
{
    public class Home
    {
    }

    public class PatientList
    {
        public List<PatientExport> list { get; set; }
        public PatientList()
        {
            list = new List<PatientExport>();
        }

        public class ClinicDataExport
        {
            public List<SelectListItem> tableList { get; set; }

            public ClinicDataExport()
            {
                tableList = new List<SelectListItem>();
            }
        }
    }
}