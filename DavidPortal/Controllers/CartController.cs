using DavidCore.Abstract;
using DavidCore.Entities;
using DavidPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    public class CartController : Controller
    {
        private IDeviceRepository deviceRepository;
        private IOrderProcessor orderProcessor;

        public CartController(IDeviceRepository deviceRepository, IOrderProcessor orderProcessor)
        {
            this.deviceRepository = deviceRepository;
            this.orderProcessor = orderProcessor;
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, string deviceId, string returnUrl)
        {
            Device device = deviceRepository.Devices
                .FirstOrDefault(d => d.DeviceId == deviceId);

            if (device != null)
            {
                cart.AddItem(device, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, string deivceId, string returnUrl)
        {
            Device device = deviceRepository.Devices
                .FirstOrDefault(d => d.DeviceId == deivceId);

            if (device != null)
            {
                cart.RemoveLine(device);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetail());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetail shippingDetail)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetail);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetail);
            }
        }

    }
}