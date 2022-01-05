using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Database.DTO
{
   public  class DTOProductLenses
    {
        public long ProductLensesId { get; set; }
        public long? ProductId { get; set; }

        public long? LensesId { get; set; }
    }
}
