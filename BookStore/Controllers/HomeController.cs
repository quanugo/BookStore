using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using X.PagedList;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private const int pageSize = 6;
        public const string CARTKEY = "cart";

        [Route("/home")]
        public IActionResult Index(int categoryId, int? page)
        {
            int pageIndex = page ?? 1;
            IPagedList<Book> list = null;
            List<Book> books = new List<Book>();
            Dictionary<int, string> Categories = GetCategories();

            using (var context = new Book_SellingContext())
            {
                if (categoryId == 0) books = context.Books.ToList();
                else books = context.Books.Where(x => x.Genre.Equals(Categories[categoryId])).ToList();
                list = books.ToPagedList(pageIndex, pageSize);
                ViewBag.Category = Categories;
                ViewBag.categoryId = categoryId;
                ViewBag.PageIndex = pageIndex;
            }
            return View(list);
        }
        [Route("/search")]
        public IActionResult Search(string search,int? page)
        {
            int pageIndex = page ?? 1;
            IPagedList<Book> list = null;
            List<Book> books = new List<Book>();
            Dictionary<int, string> Categories = GetCategories();
            using (var context = new Book_SellingContext())
            {
                books = context.Books.Where(x => x.BookName.Contains(search)).ToList();
                list = books.ToPagedList(pageIndex,pageSize);
            }
            ViewBag.Category = Categories;
            ViewBag.Search = search;
            ViewBag.PageIndex = pageIndex;
            return View(list);
        }
        [Route("/about")]
        public IActionResult About()
        {
            Dictionary<int, string> Categories = GetCategories();
            ViewBag.Category = Categories;
            return View("About");
        }
        [Route("/cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }
        List<CartItem> GetCartItems()
        {

            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
        [Route("/addcart/{bookid:int}")]
        public IActionResult AddToCart([FromRoute]int bookid)
        {
            using (var context = new Book_SellingContext())
            {
                var books = context.Books
                .Where(b => b.BookId == bookid)
                .FirstOrDefault();
                if (books == null)
                    return NotFound("Cart is empty!");

                var cart = GetCartItems();
                var cartitem = cart.Find(b => b.Book.BookId == bookid);
                if (cartitem != null)
                {
                    cartitem.Quantity++;
                }
                else
                {
                    cart.Add(new CartItem() { Quantity = 1, Book = books });
                }
                SaveCartSession(cart);
                return RedirectToAction("Cart");
            }
        }
        [Route("/updatecart/{bookid:int}/{quantity:int}")]
        public IActionResult UpdateCart([FromRoute] int bookid, [FromRoute] int quantity)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.Book.BookId == bookid);

            if (cartitem != null)
            {
                cartitem.Quantity = quantity;
            }
            SaveCartSession(cart);
            return RedirectToAction("Cart");
        }
        [Route("/removecart/{bookid:int}")]
        public IActionResult RemoveCart([FromRoute] int bookid)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.Book.BookId == bookid);
            if (cartitem != null)
            {
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction("Cart");
        }
        [Route("/submit")]
        public IActionResult DoSubmit()
        {
            User currentUser = null;
            var cart = GetCartItems();
            using(var context = new Book_SellingContext())
            {
                var session = HttpContext.Session;
                string jsonuser = session.GetString("User");
                currentUser = JsonConvert.DeserializeObject<User>(jsonuser);              
                Order newOrder = new Order();
                newOrder.OrderDate = DateTime.Now;
                newOrder.ShippedDate = DateTime.Now;
                newOrder.ShipId = 1;
                newOrder.Address = "FPT";
                newOrder.StatusId = 1;
                newOrder.UserId = currentUser.UserId;
                context.Orders.Add(newOrder);
                foreach (CartItem item in cart)
                {
                    OrderBook orderBook = new OrderBook();
                    orderBook.OrderId = context.Orders.OrderBy(x => x.OrderId).Last().OrderId + 1;
                    orderBook.BookId = item.Book.BookId;
                    orderBook.Quantity = item.Quantity;
                    context.OrderBooks.Add(orderBook);
                }
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        private Dictionary<int, string> GetCategories()
        {
            int count = 1;
            Dictionary<int, string> Categories = new Dictionary<int, string>();
            using (var context = new Book_SellingContext())
            {
                List<Book> books = context.Books.ToList();
                Categories.Add(count, "Hài");
                foreach (Book b in books)
                {
                    bool flag = true;

                    for (int i = 0; i < Categories.Count; i++)
                    {
                        if (Categories.ContainsValue(b.Genre))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true) Categories.Add(++count, b.Genre);
                }
                return Categories;
            }
        }
    }
}