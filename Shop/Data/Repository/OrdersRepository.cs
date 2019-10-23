using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDbContent appDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDbContent appDBContent, ShopCart shopCart)
        {
            this.appDbContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContent.Order.Add(order);

            var items = shopCart.ListShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = el.Car.Id,
                    OrderID = order.Id,
                    Price = el.Car.Price
                };
                appDbContent.OrderDetail.Add(orderDetail);
            }
            appDbContent.SaveChanges();
        }
    }
}
