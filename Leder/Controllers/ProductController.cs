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
                new Product{ Name = "Tone Oilnume 中型後背包", Category="Backpack",Price=300, Photo="Tone Oilnume 中型後背包.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Tone Oilnume 後背包", Category="Backpack",Price=350, Photo="Tone Oilnume 後背包.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Bridle方形零錢包", Category="CoinWallet",Price=100, Photo="Bridle方形零錢包.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Tone Oilnume 蛙嘴式迷你零錢包", Category="CoinWallet",Price=80, Photo="Tone Oilnume 蛙嘴式迷你零錢包.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Tone Oilnume 蛙嘴式零錢長夾", Category="Longclip",Price=150, Photo="Tone Oilnume 蛙嘴式零錢長夾.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Urbano 長皮夾", Category="Longclip",Price=180, Photo="Urbano 長皮夾.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Cordovan 馬臀皮名片夾", Category="NameCard",Price=70, Photo="Cordovan 馬臀皮名片夾.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Urbano 拉鍊卡片夾", Category="NameCard",Price=50, Photo="Urbano 拉鍊卡片夾.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Plota 防水兩用斜背包", Category="Totebag",Price=600, Photo="Plota 防水兩用斜背包.jpg", ProductPage="https://shorturl.at/aiOS0" },
                new Product{ Name = "Tone Oilnume 迷你郵差包", Category="Totebag",Price=500, Photo="Tone Oilnume 迷你郵差包.jpg", ProductPage="https://shorturl.at/aiOS0" },

            };

        //把Model帶入，傳給View
        
        public ActionResult Product()
        {
            return View();
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