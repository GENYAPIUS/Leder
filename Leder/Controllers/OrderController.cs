using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leder.Models;
using Leder.ViewModels;

namespace Leder.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            OrderViewModel orderViewModel = (OrderViewModel)Session["ReceiverData"];
            if(orderViewModel != null)
            {
                LederContext db = new LederContext();
                Order orders = new Order
                {
                    OrderId = Guid.NewGuid(),
                    Email = orderViewModel.Email,
                    RecieverName = orderViewModel.RecieverName,
                    RecieverPhone = orderViewModel.RecieverPhone,
                    RecieverAddress = orderViewModel.RecieverAddress,
                    RecieverZipCode = orderViewModel.RecieverZipCode,
                    OrderDate = DateTime.Now,
                    TotalAmount = orderViewModel.Carts.TotalAmount,
                    PayStatus = "貨到付款",
                    OrderStatus = "未出貨"

                };
                db.Orders.Add(orders);

                foreach (var item in orderViewModel.CartItems)
                {
                    db.OrderDetails.Add(new OrderDetail { OrderId = orders.OrderId, ProductId = item.Id, Price = item.Price, Quantity = item.Quantity, Amount = item.Amount });
                }

                db.SaveChanges();

            }

            return View();
        }        
    }
}