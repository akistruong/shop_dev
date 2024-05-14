﻿using System;
using System.Collections.Generic;

namespace AccountShop.Models;

public partial class Orderdetail
{
    public int OrderId { get; set; }

    public string ProductId { get; set; } = null!;

    public int? OdtQty { get; set; }

    public decimal? OdtPrice { get; set; }

    public virtual TblOrder Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}