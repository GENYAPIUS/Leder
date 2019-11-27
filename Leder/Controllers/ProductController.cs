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
        //側背包
        List<Product> totebags = new List<Product>
            {      
                new Product{ Id =1, Name = "Clarte 流蘇迷你箱型包", Category="Totebag", Photo="Clarte 流蘇迷你箱型包.jpg"},
                new Product{ Id =2, Name = "Diario 迷你隨行斜肩袋", Category="Totebag", Photo="Diario 迷你隨行斜肩袋.jpg"},
                new Product{ Id =3, Name = "Plota 防水兩用斜背包", Category="Totebag", Photo="Plota 防水兩用斜背包.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 兩用托特包", Category="Totebag", Photo="Tone Oilnume 兩用托特包.jpg"},
                new Product{ Id =5, Name = "Tone Oilnume 拉鍊斜背包", Category="Totebag", Photo="Tone Oilnume 拉鍊斜背包.jpg"},
                new Product{ Id =6, Name = "Tone Oilnume 迷你郵差包", Category="Totebag", Photo="Tone Oilnume 迷你郵差包.jpg"},
            };

        //後背包
        List<Product> backpacks = new List<Product>
            {
                new Product{ Id =1, Name = "Tone Oilnume 中型後背包", Category="Backpack", Photo="Tone Oilnume 中型後背包.jpg"},
                new Product{ Id =2, Name = "Tone Oilnume 後背包", Category="Backpack", Photo="Tone Oilnume 後背包.jpg"},

            };

        //長夾
        List<Product> longclips = new List<Product>
            {
                new Product{ Id =1, Name = "Belchord 長夾", Category="Longclip", Photo="Belchord 長夾.jpg"},
                new Product{ Id =2, Name = "Diario 長夾", Category="Longclip", Photo="Diario 長夾.jpg"},
                new Product{ Id =3, Name = "Tone Oilnume 蛙嘴式零錢長夾", Category="Longclip", Photo="Tone Oilnume 蛙嘴式零錢長夾.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 纏繞式長夾", Category="Longclip", Photo="Tone Oilnume 纏繞式長夾.jpg"},
                new Product{ Id =5,  Name = "Urbano 長皮夾", Category="Longclip", Photo="Urbano 長皮夾.jpg"},

        };

        //零錢包
        List<Product> coinwallets = new List<Product>
            {
                new Product{ Id =1, Name = "Belchord零錢包", Category="Coinwallet", Photo="Belchord零錢包.jpg"},
                new Product{ Id =2, Name = "Bridle方形零錢包", Category="Coinwallet", Photo="Bridle方形零錢包.jpg"},
                new Product{ Id =3, Name = "Diario 雙釦式零錢包", Category="Coinwallet", Photo="Diario 雙釦式零錢包.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Category="Coinwallet", Photo="Tone Oilnume 蛙嘴式迷你零錢包.jpg"},
                new Product{ Id =5, Name = "Tone Oilnume 蛙嘴式零錢袋", Category="Coinwallet", Photo="Tone Oilnume 蛙嘴式零錢袋.jpg"},
                new Product{ Id =6, Name = "Urbano零錢包", Category="Coinwallet", Photo="Urbano零錢包.jpg"},
        };

        //名片夾
        List<Product> namecards = new List<Product>
            {
                new Product{ Id =1, Name = "Bridle 名片夾", Category="Namecard", Photo="Bridle 名片夾.jpg"},
                new Product{ Id =2, Name = "Clarte 信封名片夾", Category="Namecard", Photo="Clarte 信封名片夾.jpg"},
                new Product{ Id =3, Name = "Cordovan 馬臀皮名片夾", Category="Namecard", Photo="Cordovan 馬臀皮名片夾.jpg"},
                new Product{ Id =4, Name = "Cordovan 馬臀皮票卡套", Category="Namecard", Photo="Cordovan 馬臀皮票卡套.jpg"},
                new Product{ Id =5, Name = "Urbano 名片夾", Category="Namecard", Photo="Urbano 名片夾.jpg"},
                new Product{ Id =6, Name = "Urbano 拉鍊卡片夾", Category="Namecard", Photo="Urbano 拉鍊卡片夾.jpg"},
        };


        //預設Index是顯示側背包類別
        public ActionResult Index()
        {
            return View(totebags);
        }

        //後背包類別
        public ActionResult Backpack()
        {
            return View(backpacks);
        }

        //長夾類別
        public ActionResult Longclip()
        {
            return View(longclips);
        }

        //零錢包類別
        public ActionResult Coinwallet()
        {
            return View(coinwallets);
        }

        //名片夾類別
        public ActionResult Namecard()
        {
            return View(namecards);
        }

        //ProductDetail試做
        public ActionResult ProductDetail()
        {
            return View();
        }

    }
}