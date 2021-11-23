using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THDShop.ViewModel.Product;

namespace THDShop.Controllers
{
    public class HomeUserController : Controller
    {
        // GET: HomeUser
        QLLaptopShopEntities _db = new QLLaptopShopEntities();

        public HomeUserController()
        {
            ProductSingleton.Instance.Init(_db);
        }

        public ActionResult Index()
        {
            var query = from c in _db.PRODUCTS
                        select new ProductDTO
                        {
                            ID = c.ID,
                            NAME = c.NAME,
                            PRICE = c.PRICE,
                            ORI_PRICE = c.ORI_PRICE,
                            DESCRIPTION = c.DESCRIPTION,
                            CATEGORYNAME = c.CATEGORIES.NAME,
                            IDCATEGORY = c.IDCATEGORY,
                            QUANTITY = c.QUANTITY,
                            IMAGE = c.IMAGE,
                            DESCRIPTION_CPU = c.DESCRIPTION_CPU,
                            DESCRIPTION_RAM = c.DESCRIPTION_RAM,
                            DESCRIPTION_STORAGE = c.DESCRIPTION_STORAGE,
                            DESCRIPTION_CARD = c.DESCRIPTION_CARD,
                            DESCRIPTION_SCREEN = c.DESCRIPTION_SCREEN,
                            DESCRIPTION_WEIGHT = c.DESCRIPTION_WEIGHT
                        };
            return View(query.ToList());

        }
      
    }
}