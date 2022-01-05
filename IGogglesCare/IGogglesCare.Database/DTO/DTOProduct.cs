using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
    public class DTOProduct 
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public string SKU { get; set; }
        public float Price { get; set; }
        public string Thumbnail { get; set; }
        

        public float EyeHeight { get; set; }
        public float EyeWidth { get; set; }

        public float NoseBridge { get; set; }

        public float TempleSize { get; set; }

        public float FrameSize { get; set; }
        public string FrameShape { get; set; }

        public long? ProductQuantity { get; set; }

        public bool? IsAvailable { get; set; }

        public string IsAvailableStatus
        {
            get
            {
                return Convert.ToBoolean(IsAvailable) == true ? "Yes" : "No";
            }
        }

        public bool? IsFeatured { get; set; }

        public string IsFeaturedStatus
        {
            get
            {
                return Convert.ToBoolean(IsFeatured) == true ? "Yes" : "No";
            }
        }

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
