using IGogglesCare.Database.DTO;
using IGogglesCare.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Repository
{
    public class OrderRepository : Repository
    {
        #region Order
        public virtual List<DTOOrder> GetOrder()
        {
            var listOrder = db.Orders
            .Where(x => x.IsActive == true || x.IsActive == null)
            .ToList()
            .Select(x => new DTOOrder()
            {

                OrderId = x.OrderId,
                
                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                Email = x.Email,
                Phone = x.Phone,
                OrderDate= x.OrderDate,
                OrderStatusId = x.OrderId,
                OrderStatus =x.CT_OrderStatus == null ? "":x.CT_OrderStatus.Name,
                Company = x.Company,
                BillingAddress = x.BillingAddress,
                ShippingAddress = x.ShippingAddress,
                
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,



            })
            .ToList();
            return listOrder;
        }

        public virtual DTOOrder GetOrder(long Id)
        {
            var obj = db.Orders
            .Where(x => (x.IsActive == true || x.IsActive == null))
            .Where(x => x.OrderId == Id).FirstOrDefault();

            if (obj != null)
            {

                DTOOrder DTOObj = new DTOOrder();
                DTOObj.OrderId = obj.OrderId;
                DTOObj.CustomerName = obj.CustomerName;
                DTOObj.Email = obj.Email;
                DTOObj.Phone = obj.Phone;
                DTOObj.OrderDate = obj.OrderDate;
                DTOObj.OrderStatusId = obj.OrderStatusId;
                DTOObj.Company = obj.Company;
                DTOObj.OrderStatus =obj.CT_OrderStatus.Name;
                DTOObj.ShippingAddress = obj.ShippingAddress;
                DTOObj.BillingAddress = obj.BillingAddress;
               
                DTOObj.IsActive = obj.IsActive;
                DTOObj.CreatedDate = obj.CreatedDate;
                DTOObj.CreatedBy = obj.CreatedBy;
                DTOObj.UpdatedDate = obj.UpdatedDate;
                DTOObj.UpdatedBy = obj.UpdatedBy;




                return DTOObj;

            }
            return null;
        }

        public DTOOrder SaveOrder(DTOOrder DTOObj)
        {
            var dbObj = db.Orders.Where(x => x.OrderId == DTOObj.OrderId).FirstOrDefault();
            if (dbObj != null)
            {

                dbObj.CustomerId = DTOObj.CustomerId;
                dbObj.OrderId = DTOObj.OrderId;
                dbObj.CustomerName = DTOObj.CustomerName;
                dbObj.Email = DTOObj.Email;
                dbObj.CustomerId = DTOObj.CustomerId;
                dbObj.Phone = DTOObj.Phone;
                dbObj.OrderDate = DTOObj.OrderDate;
                dbObj.OrderStatusId = DTOObj.OrderStatusId;
                dbObj.Company = DTOObj.Company;
                dbObj.BillingAddress = DTOObj.BillingAddress;
                dbObj.ShippingAddress = DTOObj.ShippingAddress;
             

                dbObj.CreatedDate = DTOObj.CreatedDate;
                dbObj.CreatedBy = DTOObj.CreatedBy;
                dbObj.UpdatedDate = DateTime.Now;
                dbObj.UpdatedBy = Common.Current.SessionUser.UserId;
                dbObj.IsActive = DTOObj.IsActive;


            }
            else
            {
                dbObj = new Order();
                dbObj.CustomerId = DTOObj.CustomerId;
                dbObj.OrderId = DTOObj.OrderId;
                dbObj.CustomerName = DTOObj.CustomerName;
                dbObj.Email = DTOObj.Email;
                dbObj.CustomerId = DTOObj.CustomerId;
                dbObj.Phone = DTOObj.Phone;
                dbObj.OrderDate = DTOObj.OrderDate;
                dbObj.OrderStatusId = DTOObj.OrderStatusId;
                dbObj.Company = DTOObj.Company;
                dbObj.BillingAddress = DTOObj.BillingAddress + ","+ DTOObj.City + "," + DTOObj.State;
                dbObj.ShippingAddress = DTOObj.ShippingAddress;


                dbObj.IsActive = DTOObj.IsActive;
                dbObj.CreatedBy = Common.Current.SessionUser.UserId;
                dbObj.UpdatedBy = DTOObj.UpdatedBy;
                dbObj.UpdatedDate = DTOObj.UpdatedDate;
                dbObj.CreatedDate = DateTime.Now;
                db.Orders.Add(dbObj);
            }

            db.SaveChanges();

            DTOObj.OrderId = dbObj.OrderId;
            DTOObj.CustomerId = dbObj.CustomerId;
            DTOObj.Email = dbObj.Email;
            DTOObj.CustomerName = dbObj.CustomerName;
            DTOObj.Phone = dbObj.Phone;
            DTOObj.OrderDate = dbObj.OrderDate;
            DTOObj.OrderStatusId = dbObj.OrderStatusId;
            DTOObj.Company = dbObj.Company;
           
            DTOObj.BillingAddress = dbObj.BillingAddress;
            DTOObj.ShippingAddress = dbObj.ShippingAddress;

            DTOObj.IsActive = dbObj.IsActive;
            DTOObj.CreatedDate = dbObj.CreatedDate;
            DTOObj.CreatedBy = dbObj.CreatedBy;
            DTOObj.UpdatedDate = dbObj.UpdatedDate;
            DTOObj.UpdatedBy = dbObj.UpdatedBy;

            return DTOObj;
        }


        #endregion Order

        #region Filter On Order

        public virtual List<DTOOrder> GetOrderByBillingAddress()
        {
            var listOrder = db.Orders
            .Where(x => x.IsActive == true || x.IsActive == null)
            .ToList()
            .Select(x => new DTOOrder()
            {

                OrderId = x.OrderId,

                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                Email = x.Email,
                Phone = x.Phone,
                OrderDate = x.OrderDate,
                OrderStatusId = x.OrderId,
                OrderStatus = x.CT_OrderStatus == null ? "" : x.CT_OrderStatus.Name,
                Company = x.Company,
                BillingAddress = x.BillingAddress,
                ShippingAddress = x.ShippingAddress,

                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,



            })
            .ToList();
            return listOrder;
        }
        

        public virtual List<DTOOrder> GetOrderByCity(string city)
        {
            var listOrder = db.Orders
            .Where(x => x.IsActive == true || x.IsActive == null)
            .Where(x=>x.BillingAddress.Split(',').Reverse().Take(2).Last() == city)
            .ToList()
            .Select(x => new DTOOrder()
            {

                OrderId = x.OrderId,

                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                Email = x.Email,
                Phone = x.Phone,
                OrderDate = x.OrderDate,
                OrderStatusId = x.OrderId,
                OrderStatus = x.CT_OrderStatus == null ? "" : x.CT_OrderStatus.Name,
                Company = x.Company,
                BillingAddress = x.BillingAddress,
                ShippingAddress = x.ShippingAddress,

                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,



            })
            .ToList();
            return listOrder;
        }

        public virtual List<DTOOrder> GetOrderByState(string State)
        {
            var listOrder = db.Orders
            .Where(x => x.IsActive == true || x.IsActive == null)
            
            .Where(x => x.BillingAddress.Split(',').Reverse().Take(1).Last() == State)
            .ToList()
            .Select(x => new DTOOrder()
            {

                OrderId = x.OrderId,

                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                Email = x.Email,
                Phone = x.Phone,
                OrderDate = x.OrderDate,
                OrderStatusId = x.OrderId,
                OrderStatus = x.CT_OrderStatus == null ? "" : x.CT_OrderStatus.Name,
                Company = x.Company,
                BillingAddress = x.BillingAddress,
                ShippingAddress = x.ShippingAddress,

                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,



            })
            .ToList();
            return listOrder;
        }


        public DTOOrder Set_IsActive(long Id, bool Value)
        {
            var dbObj = db.Orders.Where(x => x.OrderId == Id).FirstOrDefault();
            if (dbObj != null)
            {

                dbObj.IsActive = Value;


            }


            db.SaveChanges();

            DTOOrder DTOObj = new DTOOrder();
            DTOObj.OrderId = dbObj.OrderId;
            DTOObj.CustomerName = dbObj.CustomerName;
            DTOObj.Email = dbObj.Email;
            DTOObj.Phone = dbObj.Phone;
            DTOObj.OrderDate = dbObj.OrderDate;
            DTOObj.OrderStatusId = dbObj.OrderStatusId;
            DTOObj.Company = dbObj.Company;
            DTOObj.OrderStatus = dbObj.CT_OrderStatus.Name;
            DTOObj.ShippingAddress = dbObj.ShippingAddress;
            DTOObj.BillingAddress = dbObj.BillingAddress;

            DTOObj.IsActive = dbObj.IsActive;
            DTOObj.CreatedDate = dbObj.CreatedDate;
            DTOObj.CreatedBy = dbObj.CreatedBy;
            DTOObj.UpdatedDate = dbObj.UpdatedDate;
            DTOObj.UpdatedBy = dbObj.UpdatedBy;


            return DTOObj;
        }
        #endregion

    }
}
