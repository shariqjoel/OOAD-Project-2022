using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
   public class DTOCart
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public long Quantity { get; set; }

        public float bill { get; set; }
    }
}
