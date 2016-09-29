using DavidPortal.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidPortal.Models
{
    public class MenuProvider : IMenuProvider
    {
        private IList<MenuViewModel> menuList = new List<MenuViewModel>();

        public MenuProvider()
        {
            MenuViewModel menuViewModel = new MenuViewModel() { Menu = "地图", Controller = "Map", Action = "Index" };
            menuList.Add(menuViewModel);
            menuViewModel = new MenuViewModel() { Menu = "医院", Controller = "Hospital", Action = "Index" };
            menuList.Add(menuViewModel);
            menuViewModel = new MenuViewModel() { Menu = "设备", Controller = "Device", Action = "Index" };
            menuList.Add(menuViewModel);
        }

        public IEnumerable<MenuViewModel> MenuViewModels
        {
            get { return menuList; }
        }
    }
}