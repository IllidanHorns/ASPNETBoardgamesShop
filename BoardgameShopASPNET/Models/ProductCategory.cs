﻿using System;
using System.Collections.Generic;

namespace BoardgameShopASPNET.Models;

public partial class ProductCategory
{
    public int IdCategory { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
