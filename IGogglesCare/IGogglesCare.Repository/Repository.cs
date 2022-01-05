using IGogglesCare.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGogglesCare.Repository
{
    public abstract class Repository
    {
        IGogglesCareEntities _db = new IGogglesCareEntities();


        protected IGogglesCareEntities db
        {
            get
            {

                return _db;
            }
        }
    }

}
