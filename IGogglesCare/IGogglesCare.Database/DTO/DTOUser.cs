using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
    public class DTOUser
    {
        public long UserId { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }

        public DateTime? DOB { get; set; }
        public string DOBString
        {
            get
            {
                return DOB != null ? DOB.Value.ToString("yyyy-MM-dd") : "Not Available";
            }
        }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }

        public long? RoleId { get; set; }


        public string RoleName { get; set; }

        #region CommonProperties
        public DateTime? CreatedDate { get; set; }

        public string CreatedDateString
        {
            get
            {
                return CreatedDate != null ? CreatedDate.Value.ToString("dd/MM/yyyy") : "Not Available";
            }
        }

        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string UpdatedDateString
        {
            get
            {
                return UpdatedDate != null ? UpdatedDate.Value.ToString("dd/MM/yyyy") : "Not Available";
            }
        }


        public bool? IsActive { get; set; }

        public string IsActiveStatus
        {
            get
            {
                return Convert.ToBoolean(IsActive) == true || !(IsActive).HasValue ? "Yes" : "No";
            }
        }

        #endregion
    }
}
