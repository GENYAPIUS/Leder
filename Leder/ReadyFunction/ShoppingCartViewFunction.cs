using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leder.Models;
using Leder.ViewModels;

namespace Leder.ReadyFunction
{
    public class ShoppingCartViewFunction
    {
        //實體出Model模型
        private List<ShoppingCartViewModels> lineCollection = new List<ShoppingCartViewModels>();
        //更新取得的資料
        public void AddItem(Product product, int quantity)
         {
            //收尋對應ID的資料
             ShoppingCartViewModels line = lineCollection.Where(p => p.Product.Id == product.Id).FirstOrDefault();
            //購物車裡還沒有的產品就新增完整資料
             if (line == null)
             {
                 lineCollection.Add(new ShoppingCartViewModels
                 {
                     Product = product,
                     Quantity = quantity
                 });
             }
            //購物車裡已經有的產品就把新增的數量加進舊的裡面
            else
            {
                 line.Quantity += quantity;
             }
         }
         //從購物車刪除之前已經添加的條目的方法
         public void RemoveLine(Product product)
         {
             lineCollection.RemoveAll(l => l.Product.Id == product.Id);
         }
         //計算購物車內條目總價格
         public decimal ComputeTotalValue()
         {
             return lineCollection.Sum(e => e.Product.Price* e.Quantity);
         }
         //清空購物車的方法
         public void Clear()
         {
             lineCollection.Clear();
         }
 
         public IEnumerable<ShoppingCartViewModels> ShoppingCartViewModelss
         {
             get { return lineCollection; }
         }
    }


}