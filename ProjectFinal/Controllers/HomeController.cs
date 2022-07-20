using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFinal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ProjectFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? i)
        {
            ShoppingwebContext context = new ShoppingwebContext();
            List<Product> list = context.Products.ToList();
            list = (List<Product>)(from product in context.Products
                                   select product).ToList();
            ViewBag.Data = list;
            return View(list);
        }

        public IActionResult Detail(int? id)
        {
            ShoppingwebContext context = new ShoppingwebContext();
            Product product = context.Products.FirstOrDefault(x => x.Id == id);
            ViewBag.Product = product;
            return View(product);
        }

        public IActionResult Cart(Product cart)
        {
            List<Product> list = new List<Product>();
            ShoppingwebContext context = new ShoppingwebContext();
            Product pro = new Product();

            Product product = context.Products.FirstOrDefault(x => x.Id == cart.Id);
            string? json = HttpContext.Session.GetString("addCart");


            bool check = true;
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                list = new List<Product>();
            }

            if (list.Count == 0)
            {
                pro.Id = cart.Id;
                pro.ProductName = product.ProductName;
                pro.Image = product.Image;
                pro.Price = product.Price;
                pro.Quantity = cart.Quantity;
                list.Add(pro);
            }
            else
            {
                foreach (var i in list.ToList())
                {
                    if (i.Id == cart.Id)
                    {
                        i.Id = cart.Id;
                        i.ProductName = product.ProductName;
                        i.Image = product.Image;
                        i.Price = product.Price;
                        i.Quantity += cart.Quantity;
                        check = false;
                        //list.Add(pro);
                    }
                }
                if (check == true)
                {
                    pro.Id = cart.Id;
                    pro.ProductName = product.ProductName;
                    pro.Image = product.Image;
                    pro.Price = product.Price;
                    pro.Quantity = cart.Quantity;
                    list.Add(pro);
                }
            }

            json = JsonConvert.SerializeObject(list);
            HttpContext.Session.SetString("addCart", json);
            return RedirectToAction("ViewCart");
        }

        public IActionResult ViewCart()
        {
            List<Product> list = new List<Product>();
            string? json = HttpContext.Session.GetString("addCart");
            double total = 0;
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var i in list)
                {
                    total += (double)i.Price * i.Quantity;
                }
            }
            else
            {
                list = new List<Product>();
            }
            return View(list);
        }

        public IActionResult RemoveCart(int? id)
        {
            List<Product> list = new List<Product>();
            bool check = true;
            string? json = HttpContext.Session.GetString("addCart");
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                list = new List<Product>();
            }

            var item = list.SingleOrDefault(x => x.Id == id);

            if (item == null)
            {
                ViewBag.Data = "Can not delete";
            }
            else
            {
                list.Remove(item);
                json = JsonConvert.SerializeObject(list);
                HttpContext.Session.SetString("addCart", json);
            }

            return RedirectToAction("ViewCart");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
