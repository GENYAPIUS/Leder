using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Leder.Controllers
{
    public class ProductController : Controller
    {
        //側背包
        List<Product> Totebags = new List<Product>
            {      
                new Product{ Id =1, Name = "Clarte 流蘇迷你箱型包", Category="Totebag", Photo="Totebag1.jpg"},
                new Product{ Id =2, Name = "Diario 迷你隨行斜肩袋", Category="Totebag", Photo="Totebag2.jpg"},
                new Product{ Id =3, Name = "Plota 防水兩用斜背包", Category="Totebag", Photo="Totebag3.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 兩用托特包", Category="Totebag", Photo="Totebag4.jpg"},
                new Product{ Id =5, Name = "Tone Oilnume 拉鍊斜背包", Category="Totebag", Photo="Totebag5.jpg"},
                new Product{ Id =6, Name = "Tone Oilnume 迷你郵差包", Category="Totebag", Photo="Totebag6.jpg"},
            };

        //後背包
        List<Product> Backpacks = new List<Product>
            {
                new Product{ Id =1, Name = "Tone Oilnume 中型後背包", Category="Backpack", Photo="Backpack1.jpg"},
                new Product{ Id =2, Name = "Tone Oilnume 後背包", Category="Backpack", Photo="Backpack2.jpg"},

            };

        //長夾
        List<Product> Longclips = new List<Product>
            {
                new Product{ Id =1, Name = "Belchord 長夾", Category="Longclip", Photo="Longclip1.jpg"},
                new Product{ Id =2, Name = "Diario 長夾", Category="Longclip", Photo="Longclip2.jpg"},
                new Product{ Id =3, Name = "Tone Oilnume 蛙嘴式零錢長夾", Category="Longclip", Photo="Longclip3.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 纏繞式長夾", Category="Longclip", Photo="Longclip4.jpg"},
                new Product{ Id =5,  Name = "Urbano 長皮夾", Category="Longclip", Photo="Longclip5.jpg"},

        };

        //零錢包
        List<Product> Coinwallets = new List<Product>
            {
                new Product{ Id =1, Name = "Belchord零錢包", Category="Coinwallet", Photo="Coinwallet1.jpg"},
                new Product{ Id =2, Name = "Bridle方形零錢包", Category="Coinwallet", Photo="Coinwallet2.jpg"},
                new Product{ Id =3, Name = "Diario 雙釦式零錢包", Category="Coinwallet", Photo="Coinwallet3.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Category="Coinwallet", Photo="Coinwallet4.jpg"},
                new Product{ Id =5, Name = "Tone Oilnume 蛙嘴式零錢袋", Category="Coinwallet", Photo="Coinwallet5.jpg"},
                new Product{ Id =6, Name = "Urbano零錢包", Category="Coinwallet", Photo="Coinwallet6.jpg"},
        };

        //名片夾
        List<Product> Namecards = new List<Product>
            {
                new Product{ Id =1, Name = "Bridle 名片夾", Category="Namecard", Photo="Namecard1.jpg"},
                new Product{ Id =2, Name = "Clarte 信封名片夾", Category="Namecard", Photo="Namecard2.jpg"},
                new Product{ Id =3, Name = "Cordovan 馬臀皮名片夾", Category="Namecard", Photo="Namecard3.jpg"},
                new Product{ Id =4, Name = "Cordovan 馬臀皮票卡套", Category="Namecard", Photo="Namecard4.jpg"},
                new Product{ Id =5, Name = "Urbano 名片夾", Category="Namecard", Photo="Namecard5"},
                new Product{ Id =6, Name = "Urbano 拉鍊卡片夾", Category="Namecard", Photo="Namecard6"},
        };


        //預設Index是顯示側背包類別
        public ActionResult Index()
        {
            return View(Totebags);
        }

        //後背包類別
        public ActionResult Backpack()
        {
            return View(Backpacks);
        }

        //長夾類別
        public ActionResult Longclip()
        {
            return View(Longclips);
        }

        //零錢包類別
        public ActionResult Coinwallet()
        {
            return View(Coinwallets);
        }

        //名片夾類別
        public ActionResult Namecard()
        {
            return View(Namecards);
        }

        //ProductDetail試做
        public ActionResult ProductDetail(int? Id, string Category) 
        {
            
            var prd = cat.Where(x => x.Category == Category);
            var item = prd.Where((x) => x.Id == Id);
            return View(item);

        }


    }
}