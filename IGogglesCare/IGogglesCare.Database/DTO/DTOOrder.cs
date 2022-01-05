using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
    public class DTOOrder
    {
        public long OrderId { get; set; }
        public long? CustomerId { get; set; }

     
        public string CustomerName { get; set; }

       
        public string Company { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public string BillingAddress { get; set; }

        public string ShippingAddress { get;  set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderDateString
        {
            get
            {
                return OrderDate != null ? OrderDate.Value.ToString("dd/MM/yyyy") : "Not Available";
            }
        }
        public long? OrderStatusId { get; set; }
        public  string OrderStatus { get; set; }

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
