using IGogglesCare.Common;
using IGogglesCare.Database.DTO;
using IGogglesCare.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGogglesCare.Controllers
{
    public class ProductController : Controller
    {
    
        // GET: Product
        public ActionResult Index()
        {
            ProductRepository productRepository = new ProductRepository();
            ViewBag.List = productRepository.GetProduct();
            return View();
        }


        public ActionResult Details(string Id)
        {
            ProductRepository productRepository = new ProductRepository();

            if (!String.IsNullOrEmpty(Id))
            {
                var item = productRepository.GetProduct(Convert.ToInt64(Id));
                ViewBag.item = item;
            }
           
            return View();
        }

        //Get Product
        public ActionResult CreateOrEdit(string Id)
        {
            if (!String.IsNullOrEmpty(Id))
            {
                long ItemId = 0;
                var IsId = Int64.TryParse(Id, out ItemId);
                if (IsId)
                {
                    ProductRepository productRepository = new ProductRepository();
                    var item = productRepository.GetProduct(ItemId);
                    ViewBag.Item = item;
                }
                else
                {
                    return View("All");
                }
            }
            else
            {

                ViewBag.Item = new DTOProduct();
            }
            return View();
        }
        [HttpPost]
        public ActionResult SaveProduct(DTOProduct obj, HttpPostedFileBase file)
        {
            RequestMessage requestMessage = new RequestMessage();

            // Initialize Respository
            ProductRepository objProductRepository = new ProductRepository();
            try
            {
                requestMessage.IsSuccess = true;

                //if (file != null)
                //{
                //    // Save Object Product
                //    string Image1Name = System.IO.Path.GetFileName(file.FileName);
                //    string Image2Name = System.IO.Path.GetFileName(file.FileName);
                //    string physicalPath = Server.MapPath("~/Content/ProductImages/" + Image1Name);
                //    file.SaveAs(physicalPath);

                //    obj.Image1 = Image1Name;
                




                    obj = objProductRepository.SaveProduct(obj);
               
                requestMessage.ResponseObject = obj;
            }
            catch (Exception ex)
            {
                requestMessage.IsSuccess = false;
                requestMessage.ResponseString = "Error in Saving Data";
                requestMessage.ResponseObject = ex;
            }


            // return to action
            return Json(requestMessage);
           
        }


    }
}