using System;
using IGogglesCare.Common;
using IGogglesCare.Database.DTO;
using IGogglesCare.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGogglesCare.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
      
        public ActionResult Index()
        {
            UserRepository userRepository = new UserRepository();
            ViewBag.List = userRepository.GetUser();
            return View();
        }

        //Get User
        public ActionResult CreateOrEdit(string Id)
        {
            if (!String.IsNullOrEmpty(Id))
            {
                long ItemId = 0;
                var IsId = Int64.TryParse(Id, out ItemId);
                if (IsId)
                {
                    UserRepository UserRepository = new UserRepository();
                    var item = UserRepository.GetUser(ItemId);
                    ViewBag.Item = item;
                }
                else
                {
                    return View("All");
                }
            }
            else
            {

                ViewBag.Item = new DTOUser();
            }
            return View();
        }
        [HttpPost]
        public ActionResult SaveUser(DTOUser obj)
        {
            RequestMessage requestMessage = new RequestMessage();

            // Initialize Respository
            UserRepository objUserRepository = new UserRepository();
            try
            {
                requestMessage.IsSuccess = true;

                // Save Object User
                obj = objUserRepository.SaveUser(obj);
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