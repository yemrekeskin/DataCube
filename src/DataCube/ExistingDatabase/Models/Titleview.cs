﻿using System;
using System.Collections.Generic;

namespace ExistingDatabase.Models
{
    public partial class Titleview
    {
        public string Title { get; set; }
        public byte? AuOrd { get; set; }
        public string AuLname { get; set; }
        public decimal? Price { get; set; }
        public int? YtdSales { get; set; }
        public string PubId { get; set; }
    }
}
