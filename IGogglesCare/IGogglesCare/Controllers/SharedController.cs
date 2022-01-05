using IGogglesCare.Database.DTO;
using IGogglesCare.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGogglesCare.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult Index()
        {
            return View();
        }

        ImageRepository imageRepository = new ImageRepository();

        public JsonResult UploadImage()
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            try
            {
                var file = Request.Files[0];

                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

                var path = Path.Combine(Server.MapPath("~/Content/ProductImages/"), fileName);

                file.SaveAs(path);

                var dbImage = new DTOImages();
                dbImage.URL = fileName;

                long ImageId = imageRepository.SaveImage(dbImage);



                result.Data = new { Success = true, ImageURL = string.Format("~/Content/ProductImages/{0}", fileName) };

             
            }
            catch (Exception ex)
            {
                result.Data = new { Success = false, Message = ex.Message };
            }

            return result;
        }
    }
}