using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leder.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>
            {
                new Product{ Name = "Backpack001", Category="Backpack", Photo="Backpack.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Backpack002", Category="Backpack", Photo="Backpack2.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "CoinWallet001", Category="CoinWallet", Photo="CoinWallet.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "CoinWallet002", Category="CoinWallet", Photo="CoinWallet2.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Longclip001", Category="Longclip", Photo="Longclip.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Longclip002", Category="Longclip", Photo="Longclip2.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "NameCard001", Category="NameCard", Photo="NameCard.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "NameCard002", Category="NameCard", Photo="NameCard2.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Totebag001", Category="Totebag", Photo="Totebag.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Totebag002", Category="Totebag", Photo="Totebag2.jpg", ProductPage="https://shorturl.at/aiOS0" },

            };

        //把Model帶入，傳給View
        public ActionResult Product()
        {
            return View(products);
        }

        //預設是顯示側背包類別
        public ActionResult ProductMainPage()
        {
            return View();
        }

        //後背包類別
        public ActionResult Backpack()
        {
            return View();
        }

        //長夾類別
        public ActionResult Longclip()
        {
            return View();
        }

        //零錢包類別
        public ActionResult Coinwallet()
        {
            return View();
        }

        //名片夾類別
        public ActionResult Namecard()
        {
            return View();
        }



    }
}