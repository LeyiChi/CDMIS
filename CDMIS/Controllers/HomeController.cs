using System.Collections.Generic;
using System.Web.Mvc;
using CDMIS.Models;
using CDMIS.CommonLibrary;
using CDMIS.ViewModels;
using System.Data;

namespace CDMIS.Controllers
{
    [StatisticsTracker]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            PatientList model = new PatientList();
            for (int i = 1; i < 10; i++)
            {
                PatientExport pt = new PatientExport();
                pt.PatientId = "11" + i;
                pt.PatientName = "哈哈" + i;
                pt.HUserId = "22" + i;
                pt.HospitalCode = "33";
                pt.HospitalName = "呵呵" + i;
                pt.HealthCoachId = "44";
                pt.HealthCoachName = "来来" + i;
                model.list.Add(pt);
            }
            PatientExport ppt = new PatientExport();
            ppt.PatientId = "11";
            ppt.PatientName = "哈哈";
            ppt.HUserId = "22";
            ppt.HospitalCode = "33";
            ppt.HospitalName = "就是你";
            ppt.HealthCoachId = "44";
            ppt.HealthCoachName = "来来";
            model.list.Add(ppt);
            return View(model);
        }

    }
}