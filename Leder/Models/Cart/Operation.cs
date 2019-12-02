using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Leder.Models.Cart
{
    //這個類別是提供購物車操作，目前我們僅新增一個方法GetCurrentCart()，功能是取得當前的購物車
    
    //購物車操作類別
    public static class Operation
    {
        [WebMethod(EnableSession =true)] //啟用Session
        public static Cart GetCurrentCart()//取得目前Session中的Cart物件
        {
            if(HttpContext.Current !=null)//確認System.Web.HttpContext.Current是否為空
            {
                if(HttpContext.Current.Session["Cart"]==null)//如果Session["Cart"]不存在，則新增一個空的Cart物件
                {
                    var order = new Cart(); 
                    HttpContext.Current.Session["Cart"] = order;
                }
                return (Cart)System.Web.HttpContext.Current.Session["Cart"];//回傳Session["Cart"]
            }
            else
            {
                throw new InvalidOperationException("System.Wed.HttpContext.Current為空，請檢查");
            }
        }
    }
}