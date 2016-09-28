using DavidCore.Abstract;
using DavidPortal.Infrastructure.Abstract;
using DavidPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    public class NavController : Controller
    {
        IMenuProvider menuProvier;
        public NavController(IMenuProvider menuProvier)
        {
            this.menuProvier = menuProvier;
        }

        public PartialViewResult Menu(string menu  = "")
        {
            ViewBag.SelectedModel = menu;
            return PartialView(menuProvier.MenuViewModels);
        }
    }
}