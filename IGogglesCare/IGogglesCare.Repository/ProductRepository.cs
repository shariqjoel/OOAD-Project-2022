using IGogglesCare.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using IGogglesCare.Common;
using System.Text;
using System.Threading.Tasks;
using IGogglesCare.Database.Model;

namespace IGogglesCare.Repository
{
    public class ProductRepository: Repository
    {

        #region Product
        public virtual List<DTOProduct> GetProduct()
        {
            var listProduct = db.Products
            .Where(x => x.IsActive == true || x.IsActive == null)
            .ToList()
            .Select(x => new DTOProduct()
            {

                ProductId = x.ProductId,
                Name = x.Name,
               Description = x.Description,
               Material = x.Material,
               SKU = x.SKU,
               Price = Convert.ToSingle(x.Price),
               EyeHeight = Convert.ToSingle(x.EyeHeight),
               EyeWidth = Convert.ToSingle(x.EyeWidth),
               NoseBridge = Convert.ToSingle(x.NoseBridge),
               TempleSize = Convert.ToSingle(x.TempleSize),
               FrameSize = Convert.ToSingle(x.FrameSize),
               FrameShape = x.FrameShape,
              IsAvailable = x.IsAvailable,

                  ProductQuantity =x.ProductQuantity,
                  Thumbnail = x.Thumbnail,
                  
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
               UpdatedBy  = x.UpdatedBy,

              

            })
            .ToList();
            return listProduct;
        }

        public virtual DTOProduct GetProduct(long Id)
        {
            var obj = db.Products 
            .Where(x => (x.IsActive == true || x.IsActive == null))
            .Where(x => x.ProductId == Id).FirstOrDefault();

            if (obj != null)
            {

                DTOProduct DTOObj = new DTOProduct();
                DTOObj.ProductId =obj.ProductId;
                DTOObj.Name =obj.Name;
                DTOObj.Description =obj.Description;
                DTOObj.Material =obj.Material;
                DTOObj.SKU =obj.SKU;
                DTOObj.Price = Convert.ToSingle(obj.Price);
                DTOObj.NoseBridge = Convert.ToSingle(obj.NoseBridge);
                DTOObj.EyeHeight = Convert.ToSingle(obj.EyeHeight);
                DTOObj.EyeWidth = Convert.ToSingle(obj.EyeWidth);
                DTOObj.TempleSize = Convert.ToSingle(obj.TempleSize);
                DTOObj.FrameSize = Convert.ToSingle(obj.FrameSize);
                DTOObj.FrameShape =obj.FrameShape;
                DTOObj.ProductQuantity =obj.ProductQuantity;
                DTOObj.IsAvailable =obj.IsAvailable;
                DTOObj.IsFeatured =obj.IsFeatured;
                DTOObj.Thumbnail =obj.Thumbnail; 


                DTOObj.IsActive =obj.IsActive;
                DTOObj.CreatedDate =obj.CreatedDate;
                DTOObj.CreatedBy =obj.CreatedBy;
                DTOObj.UpdatedDate =obj.UpdatedDate;
                DTOObj.UpdatedBy =obj.UpdatedBy;




                return DTOObj;

            }
            return null;
        }

        public DTOProduct SaveProduct(DTOProduct DTOObj)
        {
            var dbObj = db.Products.Where(x => x.ProductId == DTOObj.ProductId).FirstOrDefault();
            if (dbObj != null)
            {


                
                dbObj.ProductId = DTOObj.ProductId;
                dbObj.Name = DTOObj.Name;
                dbObj.Description = DTOObj.Description;
                dbObj.Material = DTOObj.Material;
                dbObj.SKU = DTOObj.SKU;
                dbObj.Price = DTOObj.Price;
                dbObj.NoseBridge = DTOObj.NoseBridge;
                dbObj.EyeHeight = DTOObj.EyeHeight;
                dbObj.EyeWidth = DTOObj.EyeWidth;
                dbObj.TempleSize = DTOObj.TempleSize;
                dbObj.FrameSize = DTOObj.FrameSize;
                dbObj.FrameShape = DTOObj.FrameShape; 
                dbObj.ProductQuantity = DTOObj.ProductQuantity;
                dbObj.IsFeatured = DTOObj.IsFeatured;
                dbObj.IsAvailable = DTOObj.IsAvailable;
                dbObj.Thumbnail = DTOObj.Thumbnail; 
             
                dbObj.Description = DTOObj.Description;
                dbObj.CreatedDate = DTOObj.CreatedDate;
                dbObj.CreatedBy = DTOObj.CreatedBy;
                dbObj.UpdatedDate = DateTime.Now;
                
                dbObj.IsActive = DTOObj.IsActive;


            }
            else
            {
                dbObj = new Product();
                dbObj.ProductId = DTOObj.ProductId;
                dbObj.Name = DTOObj.Name;
                dbObj.Description = DTOObj.Description;
                dbObj.Material = DTOObj.Material;
                dbObj.SKU = DTOObj.SKU;
                dbObj.Price = DTOObj.Price;
                dbObj.NoseBridge = DTOObj.NoseBridge;
                dbObj.EyeHeight = DTOObj.EyeHeight;
                dbObj.EyeWidth = DTOObj.EyeWidth;
                dbObj.TempleSize = DTOObj.TempleSize;
                dbObj.FrameSize = DTOObj.FrameSize;
                dbObj.FrameShape = DTOObj.FrameShape;
                dbObj.ProductQuantity = DTOObj.ProductQuantity;
                dbObj.IsFeatured = DTOObj.IsFeatured;
                dbObj.IsAvailable = DTOObj.IsAvailable;
                dbObj.Thumbnail = DTOObj.Thumbnail;
               

                dbObj.Description = DTOObj.Description;
                dbObj.IsActive = DTOObj.IsActive;
                //dbObj.CreatedBy = Common.Current.SessionUser.UserId;
                dbObj.UpdatedBy = DTOObj.UpdatedBy;
                dbObj.UpdatedDate = DTOObj.UpdatedDate;
                dbObj.CreatedDate = DateTime.Now;
                db.Products.Add(dbObj);
            }

            db.SaveChanges();

            DTOObj.ProductId =dbObj.ProductId;
            DTOObj.Name =dbObj.Name;
            DTOObj.Description =dbObj.Description;
            DTOObj.Material =dbObj.Material;
            DTOObj.SKU =dbObj.SKU;
            DTOObj.Price = Convert.ToSingle(dbObj.Price);
            DTOObj.NoseBridge = Convert.ToSingle(dbObj.NoseBridge);
            DTOObj.EyeHeight = Convert.ToSingle(dbObj.EyeHeight);
            DTOObj.EyeWidth = Convert.ToSingle(dbObj.EyeWidth);
            DTOObj.TempleSize = Convert.ToSingle(dbObj.TempleSize);
            DTOObj.FrameSize = Convert.ToSingle(dbObj.FrameSize);
            DTOObj.FrameShape =dbObj.FrameShape;
            DTOObj.ProductQuantity =dbObj.ProductQuantity;
            DTOObj.IsAvailable =dbObj.IsAvailable;
            DTOObj.IsFeatured =dbObj.IsFeatured;
            DTOObj.Thumbnail =dbObj.Thumbnail;
                     DTOObj.Description = dbObj.Description;
            DTOObj.IsActive =dbObj.IsActive;
            DTOObj.CreatedDate =dbObj.CreatedDate;
            DTOObj.CreatedBy =dbObj.CreatedBy;
            DTOObj.UpdatedDate =dbObj.UpdatedDate;
            DTOObj.UpdatedBy =dbObj.UpdatedBy;

            return DTOObj;
        }


        #endregion Product

        #region Filters
        public List<DTOProduct> GetProductByName(string Name)
        {
            var listProduct = db.Products

            .Where(x => x.IsActive == true || x.IsActive == null)
            .Where(x => x.Name == Name)
            .ToList()
            .Select(x => new DTOProduct()
            {


                ProductId = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Material = x.Material,
                SKU = x.SKU,
                Price = Convert.ToSingle(x.Price),
                EyeHeight = Convert.ToSingle(x.EyeHeight),
                EyeWidth = Convert.ToSingle(x.EyeWidth),
                NoseBridge = Convert.ToSingle(x.NoseBridge),
                TempleSize = Convert.ToSingle(x.TempleSize),
                FrameSize = Convert.ToSingle(x.FrameSize),
                FrameShape = x.FrameShape,
                IsAvailable = x.IsAvailable,

                ProductQuantity = x.ProductQuantity,
               Thumbnail = x.Thumbnail,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,


            })
            .ToList();
            return listProduct;
        }

        public virtual List<DTOProduct> GetProductBySKU(string SKU)
        {
            var listProduct = db.Products

            .Where(x => x.IsActive == true || x.IsActive == null)
            .Where(x => x.SKU == SKU)
            .ToList()
           .Select(x => new DTOProduct()
           {


               ProductId = x.ProductId,
               Name = x.Name,
               Description = x.Description,
               Material = x.Material,
               SKU = x.SKU,
               Price = Convert.ToSingle(x.Price),
               EyeHeight = Convert.ToSingle(x.EyeHeight),
               EyeWidth = Convert.ToSingle(x.EyeWidth),
               NoseBridge = Convert.ToSingle(x.NoseBridge),
               TempleSize = Convert.ToSingle(x.TempleSize),
               FrameSize = Convert.ToSingle(x.FrameSize),
               FrameShape = x.FrameShape,
               IsAvailable = x.IsAvailable,

               ProductQuantity = x.ProductQuantity,
               Thumbnail = x.Thumbnail,


               IsActive = x.IsActive,
               CreatedDate = x.CreatedDate,
               CreatedBy = x.CreatedBy,
               UpdatedDate = x.UpdatedDate,
               UpdatedBy = x.UpdatedBy,


           })
            .ToList();
            return listProduct;
        }

        public List<DTOProduct> GetProductByPrice(float Price)
        {
            var listProduct = db.Products

            .Where(x => x.IsActive == true || x.IsActive == null)
            .Where(x => x.Price == Price)
            .ToList()
            .Select(x => new DTOProduct()
            {


                ProductId = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Material = x.Material,
                SKU = x.SKU,
                Price = Convert.ToSingle(x.Price),
                EyeHeight = Convert.ToSingle(x.EyeHeight),
                EyeWidth = Convert.ToSingle(x.EyeWidth),
                NoseBridge = Convert.ToSingle(x.NoseBridge),
                TempleSize = Convert.ToSingle(x.TempleSize),
                FrameSize = Convert.ToSingle(x.FrameSize),
                FrameShape = x.FrameShape,
                IsAvailable = x.IsAvailable,

                ProductQuantity = x.ProductQuantity,
              Thumbnail = x.Thumbnail,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedDate = x.UpdatedDate,
                UpdatedBy = x.UpdatedBy,


            })
            .ToList();
            return listProduct;
        }

        public DTOProduct Set_IsActive(long Id, bool Value)
        {
            var dbObj = db.Products.Where(x => x.ProductId == Id).FirstOrDefault();
            if (dbObj != null)
            {

                dbObj.IsActive = Value;


            }


            db.SaveChanges();

            DTOProduct DTOObj = new DTOProduct();
            DTOObj.ProductId = dbObj.ProductId;
            DTOObj.Name = dbObj.Name;
            DTOObj.Description = dbObj.Description;
            DTOObj.Material = dbObj.Material;
            DTOObj.SKU = dbObj.SKU;
            DTOObj.Price = Convert.ToSingle(dbObj.Price);
            DTOObj.NoseBridge = Convert.ToSingle(dbObj.NoseBridge);
            DTOObj.EyeHeight = Convert.ToSingle(dbObj.EyeHeight);
            DTOObj.EyeWidth = Convert.ToSingle(dbObj.EyeWidth);
            DTOObj.TempleSize = Convert.ToSingle(dbObj.TempleSize);
            DTOObj.FrameSize = Convert.ToSingle(dbObj.FrameSize);
            DTOObj.FrameShape = dbObj.FrameShape;
            DTOObj.ProductQuantity = dbObj.ProductQuantity;
            DTOObj.IsAvailable = dbObj.IsAvailable;
            DTOObj.IsFeatured = dbObj.IsFeatured;
            DTOObj.Thumbnail = dbObj.Thumbnail;
            

            DTOObj.IsActive = dbObj.IsActive;
            DTOObj.CreatedDate = dbObj.CreatedDate;
            DTOObj.CreatedBy = dbObj.CreatedBy;
            DTOObj.UpdatedDate = dbObj.UpdatedDate;
            DTOObj.UpdatedBy = dbObj.UpdatedBy;

            return DTOObj;
        }

        #endregion
       
    }
}
