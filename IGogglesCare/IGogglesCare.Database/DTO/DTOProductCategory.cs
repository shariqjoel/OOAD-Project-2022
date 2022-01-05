using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
   public class DTOProductCategory
    {
        public long ProductCategoryId { get; set; }

        public long? ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }

        public long? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
