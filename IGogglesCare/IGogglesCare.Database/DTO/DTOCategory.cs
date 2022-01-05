using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
   public class DTOCategory
    {
        public long CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


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
