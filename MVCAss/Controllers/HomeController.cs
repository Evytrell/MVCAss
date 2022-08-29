using MVCAss.Models.DBModels;
using MVCAss.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MVCAss.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.OurFirstMessageToHTML = "Thanks for submitting, we will get back to you";

            return View();
        }

        [HttpPost]
        public ActionResult Register(RegInfo regInfo)
        {
            var photo = Request.Files[0];

            using (var photoStream = new MemoryStream())
            {
                try
                {
                    if (Request.Files.Count == 10)
                    {
                        ViewBag.ErrorMessage = "Kindly enter a valid file";
                        return View();
                    }
                    photo.InputStream.CopyTo(photoStream);
                    byte[] photoData = photoStream.ToArray();

                    var db = new RegisterModel();

                    Vendor xVendor = new Vendor();

                    xVendor.FirstName = regInfo.FirstName;
                    xVendor.LastName = regInfo.LastName;
                    xVendor.StoreName = regInfo.StoreName;
                    xVendor.DateOfBirth = regInfo.DateOfBirth;
                    xVendor.EmailAddress = regInfo.EmailAddress;
                    xVendor.Location = regInfo.Location;
                    xVendor.StoreInfo = regInfo.StoreInfo;
                    xVendor.PhoneNumber = regInfo.PhoneNumber;
                    xVendor.StoreAddress = regInfo.StoreAddress;
                    xVendor.StoreLogo = photoData;

                    db.Vendors.Add(xVendor);

                    db.SaveChanges();

                    ViewBag.Message = "Your store has been created";
                }
                catch (Exception ex)
                {

                    ViewBag.ErrorMessage = "Something went wrong";

                }
                return View();
            }

            return RedirectToAction("Contact");
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult DownloadZip()
        {
           // return File("~/Content/Wema BIT Grouping.xlsx", "application/vnd.ms-excel");

            return Content("0");
        }
    }
}