using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOET.Domain;

namespace SOET.Controllers
{
    public class PostItemsController : Controller
    {
        private readonly DataManager dataManager;

        public PostItemsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
         public IActionResult Index(Guid id)
        {
            if(id != default)
            {
                return View("Show", dataManager.PostItems.GetPostItemById(id));
            }

            //ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PagePostItems");
            return View(dataManager.PostItems.GetPostItems());
        }
    }
}
