using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Models;
using System.Web;
using System.Web.Mvc;
namespace MvcMusicStore.Interface
{
    public interface IShoppingCart
    {
        ShoppingCart GetCart(HttpContextBase context);
        ShoppingCart GetCart(Controller controller);

        void AddToCart(Album album);

        int RemoveFromCart(int id);
        void EmptyCart();
        int GetCount();
        decimal GetTotal();
        int CreateOrder(Order order);
        string GetCartId(HttpContextBase context);
        void MigrateCart(string userName);









    }
}
