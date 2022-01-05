using IGogglesCare.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using IGogglesCare.Common;
using IGogglesCare.Database.Model;

namespace IGogglesCare.Repository
{
   public class UserRepository : Repository
  {

        #region User
        public virtual List<DTOUser> GetUser()
        {
            var listUser = db.Users
            .Include(x=>x.Role)
            .Where(x => x.IsActive == true || x.IsActive == null)
            .ToList()
            .Select(x => new DTOUser()
            {

                UserId = x.UserId,
                Name = x.Name,
                DOB = x.DOB,
                RoleId = x.RoleId,
                RoleName = x.Role == null ? "Not Available" : x.Role.Name,
                Password = x.Password,
                EmailAddress = x.EmailAddress,
                Gender = x.Gender,
                Image = x.Image,
                Phone = x.Phone,
                ShippingAddress = x.ShippingAddress,
                BillingAddress = x.BillingAddress,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,


            })
            .ToList();
            return listUser;
        }

        public virtual DTOUser GetUser(long Id)
        {
            var obj = db.Users


                .Include(x => x.Role)
               .Where(x => (x.IsActive == true || x.IsActive == null))
            .Where(x => x.UserId == Id).FirstOrDefault();

            if (obj != null)
            {

                DTOUser DTOObj = new DTOUser();
                DTOObj.UserId = obj.UserId;
                DTOObj.Name = obj.Name;
                DTOObj.DOB = obj.DOB;
                DTOObj.RoleId = obj.RoleId;
                DTOObj.RoleName = obj.Role == null ? "" : obj.Role.Name;
                DTOObj.Password = obj.Password;
                DTOObj.EmailAddress = obj.EmailAddress;
                DTOObj.Gender = obj.Gender;
                DTOObj.ShippingAddress = obj.ShippingAddress;
                DTOObj.BillingAddress = obj.BillingAddress;
                DTOObj.Image = obj.Image;
                DTOObj.Phone = obj.Phone;
                DTOObj.IsActive = obj.IsActive;
                DTOObj.CreatedDate = obj.CreatedDate;
                DTOObj.CreatedBy = obj.CreatedBy;
                DTOObj.UpdatedDate = obj.UpdatedDate;
                DTOObj.UpdatedBy = obj.UpdatedBy;




                return DTOObj;

            }
            return null;
        }

        public DTOUser SaveUser(DTOUser DTOObj)
        {
            var dbObj = db.Users.Where(x => x.UserId == DTOObj.UserId).FirstOrDefault();
            if (dbObj != null)
            {
                dbObj.UserId = DTOObj.UserId;
                dbObj.Name = DTOObj.Name;
                dbObj.EmailAddress = DTOObj.EmailAddress;
                dbObj.Password = DTOObj.Password;
                dbObj.DOB = DTOObj.DOB;
                dbObj.Gender = DTOObj.Gender;
                dbObj.Image = DTOObj.Image;
                dbObj.ShippingAddress = DTOObj.ShippingAddress;
                dbObj.BillingAddress = DTOObj.BillingAddress;
                dbObj.RoleId = DTOObj.RoleId;
                dbObj.Phone = DTOObj.Phone;
                dbObj.CreatedDate = DTOObj.CreatedDate;
                dbObj.CreatedBy = DTOObj.CreatedBy;
                dbObj.UpdatedDate = DateTime.Now;
                dbObj.UpdatedBy = Common.Current.SessionUser.UserId;
                dbObj.IsActive = DTOObj.IsActive;


            }
            else
            {
                dbObj = new User();
                dbObj.UserId = DTOObj.UserId;
                dbObj.Name = DTOObj.Name;
                dbObj.EmailAddress = DTOObj.EmailAddress;
                dbObj.RoleId = DTOObj.RoleId;
                dbObj.Password = DTOObj.Password;
                dbObj.DOB = DTOObj.DOB;
                dbObj.Gender = DTOObj.Gender;
               
                dbObj.Image = DTOObj.Image;
                dbObj.BillingAddress = DTOObj.BillingAddress;
                dbObj.ShippingAddress= DTOObj.ShippingAddress;
                dbObj.Phone = DTOObj.Phone;
                dbObj.IsActive = DTOObj.IsActive;
                dbObj.CreatedBy = Common.Current.SessionUser.UserId;
                dbObj.UpdatedBy = DTOObj.UpdatedBy;
                dbObj.UpdatedDate = DTOObj.UpdatedDate;
                dbObj.CreatedDate = DateTime.Now;
                db.Users.Add(dbObj);
            }

            db.SaveChanges();

            DTOObj.UserId = dbObj.UserId;
            DTOObj.Name = dbObj.Name;
            DTOObj.DOB = dbObj.DOB;
            DTOObj.Phone = dbObj.Phone;
            DTOObj.Password = dbObj.Password;
            DTOObj.EmailAddress = dbObj.EmailAddress;
            DTOObj.Gender = dbObj.Gender;
            DTOObj.BillingAddress = dbObj.BillingAddress;
            DTOObj.ShippingAddress = dbObj.ShippingAddress;
            DTOObj.Image = dbObj.Image;
            DTOObj.RoleId = dbObj.RoleId;
            DTOObj.IsActive = dbObj.IsActive;
            DTOObj.CreatedDate = dbObj.CreatedDate;
            DTOObj.CreatedBy = dbObj.CreatedBy;
            DTOObj.UpdatedDate = dbObj.UpdatedDate;
            DTOObj.UpdatedBy = dbObj.UpdatedBy;

            return DTOObj;
        }


        #endregion User

        #region Filters
        public List<DTOUser> GetUserByName(string Name)
        {
            var listUser = db.Users
            .Include(x => x.Role)
            .Where(x => x.IsActive == true || x.IsActive == null)
            .Where(x=>x.Name == Name)
            .ToList()
            .Select(x => new DTOUser()
            {

                UserId = x.UserId,
                Name = x.Name,
                DOB = x.DOB,
                RoleId = x.RoleId,
                RoleName = x.Role == null ? "Not Available" : x.Role.Name,
                Password = x.Password,
                EmailAddress = x.EmailAddress,
                Gender = x.Gender,
                Image = x.Image,
                Phone = x.Phone,
                ShippingAddress = x.ShippingAddress,
                BillingAddress = x.BillingAddress,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,


            })
            .ToList();
            return listUser;
        }
     
        public virtual List<DTOUser> GetUserByRoleId(long roleId)
        {
            var listUser = db.Users

             .Include(x => x.Role)
            .Where(x => x.IsActive == true || x.IsActive == null)
            .Where(x => x.RoleId == roleId)
            .ToList()
           .Select(x => new DTOUser()
           {

               UserId = x.UserId,
               Name = x.Name,
               DOB = x.DOB,
               RoleId = x.RoleId,
               RoleName = x.Role == null ? "Not Available" : x.Role.Name,
               Password = x.Password,
               EmailAddress = x.EmailAddress,
               Gender = x.Gender,
               Image = x.Image,
               Phone = x.Phone,
               ShippingAddress = x.ShippingAddress,
               BillingAddress = x.BillingAddress,
               IsActive = x.IsActive,
               CreatedDate = x.CreatedDate,
               CreatedBy = x.CreatedBy,
               UpdatedDate = x.UpdatedDate,
               UpdatedBy = x.UpdatedBy,


           })
            .ToList();
            return listUser;
        }


        #endregion
    
   }
}
