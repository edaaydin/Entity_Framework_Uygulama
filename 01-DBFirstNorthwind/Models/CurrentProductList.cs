﻿using System;
using System.Collections.Generic;

namespace _01_DBFirstNorthwind.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
