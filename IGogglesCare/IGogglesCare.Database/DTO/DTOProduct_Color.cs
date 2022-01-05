using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
    public class DTOProduct_Color
    {
        public long Product_ColorId { get; set; }

        public  long? ColorId{ get; set; }
        public string ColorName { get; set; }

        public long? ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
