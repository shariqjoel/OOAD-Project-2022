using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
  public  class DTOProductImages
    {
        public long ProductImagesId { get; set; }

        public long? ProductId { get; set; }

        public string ProductName { get; set; }
        public long ProductPrice { get; set; }
        public long? ImageId { get; set; }

        public string ImageURL { get; set; }
    }
}
