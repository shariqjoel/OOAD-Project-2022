using System;
using IGogglesCare.Database.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGogglesCare.Database.Model;

namespace IGogglesCare.Repository
{
    public class ImageRepository:Repository
    {
        public virtual List<DTOImages> GetProduct()
        {
            var listImages = db.Images
            
            .ToList()
            .Select(x => new DTOImages()
            {

                ImageId =x.ImageId,
                URL = x.URL

            })
            .ToList();
            return listImages;
        }


        public virtual DTOImages GetProduct(long Id)
        {
            var obj = db.Images
         
            .Where(x => x.ImageId == Id).FirstOrDefault();

            if (obj != null)
            {

                DTOImages DTOObj = new DTOImages();
                DTOObj.ImageId = obj.ImageId;
                DTOObj.URL = obj.URL;



                return DTOObj;

            }
            return null;
        }



        public long SaveImage(DTOImages DTOObj)
        {
            var dbObj = db.Images.Where(x => x.ImageId == DTOObj.ImageId).FirstOrDefault();
            if (dbObj != null)
            {



                dbObj.ImageId = DTOObj.ImageId;
                dbObj.URL = DTOObj.URL;
               


            }
            else
            {
                dbObj = new Image();
                dbObj.ImageId = DTOObj.ImageId;
                dbObj.URL = DTOObj.URL;
               
                db.Images.Add(dbObj);
            }

            db.SaveChanges();

            DTOObj.ImageId = dbObj.ImageId;
            DTOObj.URL = dbObj.URL;
           

            return DTOObj.ImageId;
        }



    }
}
