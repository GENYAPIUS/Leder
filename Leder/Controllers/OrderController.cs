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
        ShoppingCartController shoppingCart = new ShoppingCartController();
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
                    PayStatus = orderViewModel.PayStatus,
                    OrderStatus = "未出貨"

                };
                db.Orders.Add(orders);

                foreach (var item in orderViewModel.CartItems)
                {
                    db.OrderDetails.Add(new OrderDetail { OrderId = orders.OrderId, ProductId = item.Id, Price = item.Price, Quantity = item.Quantity, Amount = (decimal)item.Amount });
                }

                db.SaveChanges();
                shoppingCart.ClearCart();

            }

            return View();
        }        
    }
}