﻿using aksesuar.Models;

namespace aksesuar.Dto
{
    public class CartViewModel
    {
        public List<CartItem> CartItems {  get; set; }
        public decimal GrandTotal { get; set; }

    }
}
