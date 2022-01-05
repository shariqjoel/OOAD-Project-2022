using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
    public class DTOOrderDetails
    {
        public long OrderDetailsId { get; set; }
        public long? OrderId { get; set; }

        public long? CustomerId { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string DefaultBillingAddress { get; set; }
        public string DefaultShippingAddress { get; set; }

        public string OrderCompany { get; set; }
        public string OrderBillingAddress { get; set; }

        public string OrderShippingAddress { get; set; }

        public string OrderEmail { get; set; }

        public string OrderContactNumber { get; set; }

        public long? OrderStatusId { get; set; }
        public string OrderStatus { get; set; }


        public DateTime? OrderDate { get; set; }

        public string OrderCustomerName { get; set; }
        public long? ProductId { get; set; }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductMaterial { get; set; }
        public string SKU { get; set; }
        public float ProductPrice { get; set; }


        public long? Quantity { get; set; }
    }
}
