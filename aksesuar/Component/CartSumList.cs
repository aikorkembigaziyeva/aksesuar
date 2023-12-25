using aksesuar.Data;
using aksesuar.Dto;
using aksesuar.Models;
using aksesuar.Oturum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace aksesuar.Component
{
    public class CartSumList:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CartSumList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartViewModel cartvm = new()
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };
            return View(cartvm);
        }

        
    }
}
