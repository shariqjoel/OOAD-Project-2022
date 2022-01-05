using IGogglesCare.Database.DTO;
using IGogglesCare.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGogglesCare.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        private List<DTOCart> ListCarts;
        public CheckoutController() 
        {
            ListCarts = new List<DTOCart>();

        }
    
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Cart()
        {
            return View();
        }

        
        
        [HttpPost]
        public ActionResult Cart(long Quantity,string Id)
        {
        
            ProductRepository productRepository = new ProductRepository();
            var list = productRepository.GetProduct(Convert.ToInt64(Id));

            DTOCart dTOCart = new DTOCart();
            dTOCart.ProductId = list.ProductId;
            dTOCart.Name = list.Name;
            dTOCart.Price = list.Price;
            dTOCart.Quantity = Quantity;
            dTOCart.bill = dTOCart.Price * dTOCart.Quantity;

            
            if (Session["Cart"] == null)
            {
                List<DTOCart> li = new List<DTOCart>();

                li.Add(dTOCart);
                Session["Cart"] = li;
              
                ViewBag.Cart = li.Count();


               



            }
            else 
            {
                List<DTOCart> li2 = Session["Cart"] as List<DTOCart>;


                int flag = 0;

                foreach (var item in li2)
                {
                    if (item.ProductId== dTOCart.ProductId)
                    {
                        item.Quantity += dTOCart.Quantity;
                        item.bill += dTOCart.bill;
                        flag = 1;
                      }
                }

                if (flag == 0)
                {
                    li2.Add(dTOCart);
                }
                

                Session["Cart"] = li2;
                ViewBag.Cart = li2;
               


            }

            //}

            //else
            //{
            //    List<DTOCart> lis = new List<DTOCart>();
            //    lis.Add(dTOCart);
            //    Session["cart"] = lis;
            //    ViewBag.cart = lis.Count();
            //    Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            //}
            long count = 0;
            foreach (var item in Session["Cart"] as List<DTOCart>)
            {
                count = count + item.Quantity;
                Session["Count"] = count;

            }

            Session["Count"] = count;

            return RedirectToAction("Cart");
        }
  
        public ActionResult RemoveFromCart(int productId)
        {
            List<DTOCart> cart = (List<DTOCart>)Session["Cart"];
            foreach (var item in cart)
            {
                if (item.ProductId == productId)
                {
                    cart.Remove(item);
                    break;
                }
            }

           long count = 0;
            foreach(var item in Session["Cart"] as List<DTOCart>)
            {
                count = count + item.Quantity;
               

            }
            Session["Cart"] = cart;
            Session["Count"] = count;
            return Redirect("Cart");
        }



    }
}