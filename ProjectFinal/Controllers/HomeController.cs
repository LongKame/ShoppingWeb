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

        public IActionResult Index(int? page)
        {
            ShoppingwebContext context = new ShoppingwebContext();
            List<Product> list = context.Products.ToList();
            var data = context.Products.ToList();
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 6;
            int start = (int)(page - 1) * limit;
            int totalProduct = data.Count();
            ViewBag.totalProduct = totalProduct;
            ViewBag.pageCurrent = page;
            float numberPage = (totalProduct / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var dataPro = data.OrderBy(s => s.Id).Skip(start).Take(limit);
            return View(dataPro.ToList());
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
            string? username = HttpContext.Session.GetString("username");

            if (username == null)
            {
                return RedirectToAction("Login");
            }


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
                ViewBag.Total = total;
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

        public IActionResult CRUD()
        {
            ShoppingwebContext context = new ShoppingwebContext();
            var list = (from a in context.Products
                        select a).ToList();
            return View(list);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Search(string? search, int? pageSearch)
        {
            ShoppingwebContext context = new ShoppingwebContext();
            List<Product> list = context.Products.ToList();
            var result = new List<Product>();
            if (pageSearch > 0)
            {
                pageSearch = pageSearch;
            }
            else
            {
                pageSearch = 1;
            }

            if (search == null)
            {
                ViewBag.NoResult = "Not Found";
            }
            else
            {
                result = (from a in context.Products
                          where a.ProductName.ToLower().Contains(search.ToLower())
                          select a).ToList();
                ViewBag.Result = result;
            }
            int limit = 3;
            int start = (int)(pageSearch - 1) * limit;
            int totalProduct = result.Count();
            ViewBag.totalProductSearch = totalProduct;
            ViewBag.pageCurrentSearch = pageSearch;
            float numberPage = (totalProduct / limit);
            ViewBag.numberPageSearch = (int)Math.Ceiling(numberPage) + 1;
            var dataPro = result.OrderBy(s => s.Id).Skip(start).Take(limit);
            return View(result);
        }

        public IActionResult Add()
        {
            List<Category> list = null;
            using (var context = new ShoppingwebContext())
            {
                list = context.Categories.ToList();
            }
            ViewBag.Cate = list;
            return View();
        }

        public IActionResult DoAdd(Product newProduct)
        {
            Product product = new Product();
            using (var context = new ShoppingwebContext())
            {
                context.Products.Add(newProduct);
                context.SaveChanges();
            }
            return RedirectToAction("CRUD");
        }

        public IActionResult Edit(int? id)
        {
            List<Category> list = null;
            Product product = null;
            using (var context = new ShoppingwebContext())
            {
                list = context.Categories.ToList();
                product = context.Products.FirstOrDefault(x => x.Id == id);
            }
            ViewBag.Cate = list;
            return View(product);
        }

        public IActionResult DoEdit(Product newProduct)
        {
            using (var context = new ShoppingwebContext())
            {
                Product pro = context.Products.SingleOrDefault(x => x.Id == newProduct.Id);
                pro.ProductName = newProduct.ProductName;
                pro.Image = newProduct.Image;
                pro.Quantity = newProduct.Quantity;
                pro.Price = newProduct.Price;
                pro.IdCategory = newProduct.IdCategory;
                pro.Description = newProduct.Description;
                context.SaveChanges();
            }
            return RedirectToAction("CRUD");
        }

        public IActionResult Delete(int? id)
        {
            List<Category> list = null;
            Product product = null;
            using (var context = new ShoppingwebContext())
            {
                product = context.Products.FirstOrDefault(x => x.Id == id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
            ViewBag.Cate = list;
            return RedirectToAction("CRUD");
        }


        public IActionResult DoSignIn(Account account)
        {
            var context = new ShoppingwebContext();
            Account acc = new Account();
            if (account == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                acc = context.Accounts.FirstOrDefault(x => x.Email.Equals(account.Email) && x.Password.Equals(account.Password));
                var username = JsonConvert.SerializeObject(acc.Username);
                var act = JsonConvert.SerializeObject(acc);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("act", act);
                return RedirectToAction("Index");
            }
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("act");
            return RedirectToAction("Index");
        }

        public IActionResult DoSignUp(Account accup)
        {
            if (accup == null)
            {

            }
            else
            {
                using (var context = new ShoppingwebContext())
                {
                    accup.IdRole = 2;
                    context.Accounts.Add(accup);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            ShoppingwebContext context = new ShoppingwebContext();
            string? cart = HttpContext.Session.GetString("addCart");
            var list = JsonConvert.DeserializeObject<List<Product>>(cart);
            OrderDetail orderDetail = new OrderDetail();

            var listInsertproductvalue = new List<OrderDetail>(); //you creating list of your entities

            foreach (var i in list)
            {
                listInsertproductvalue.Add(new OrderDetail
                {
                    IdProduct = i.Id,
                    Quantity = i.Quantity
                });
            }

            context.OrderDetails.AddRange(listInsertproductvalue); //here you add all new entities to context
            context.SaveChanges();

            //foreach (var i in list)
            //{
            //    orderDetail.IdProduct = i.Id;
            //    orderDetail.Quantity = i.Quantity;
            //    context.OrderDetails.Add(orderDetail);
            //    context.SaveChanges();
            //    context.Remove();
            //}

            HttpContext.Session.Remove("addCart");
            return RedirectToAction("Index");
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
