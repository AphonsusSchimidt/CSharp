using DataReaderMVC.Helper;
using DataReaderMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DataReaderMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Upload()
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {

                    string pathFolder = Server.MapPath("~/FileUpload/");
                    System.IO.DirectoryInfo dicInfo = new DirectoryInfo(pathFolder);
                    FileInfo[] fileInfo = dicInfo.GetFiles();                 
                    fileInfo.ToList().ForEach(x => x.Delete());



                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/FileUpload/"), fileName);
                    file.SaveAs(path);
                }
            }

            return RedirectToAction("Processing");
        }
        public ActionResult UploadDocument()
        {
            return View();
        }

        public ActionResult Processing()
        {
            string pathFolder = Server.MapPath("~/FileUpload/");
            System.IO.DirectoryInfo dicInfo = new DirectoryInfo(pathFolder);
            FileInfo[] fileInfo = dicInfo.GetFiles();
            string pathFile = fileInfo[0].FullName;
            List<string> type = new List<string>();
            type.Add("S");
            type.Add("S");
            type.Add("S");
            type.Add("I");
            type.Add("S");
            object obj = new object();
            List<HS> listHs = ReadPdf.GetDataByPdf(pathFile, type, "Candidate name", "Place of entry", "Result", "Overall Score", "CEFR Level");
            //System.IO.File.Delete(pathFile);
            ViewData["listData"] = listHs;
            return View();
        }
    }
}