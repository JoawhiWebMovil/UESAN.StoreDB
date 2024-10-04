﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UESAN.StoreDB.DOMAIN.Core.DTO
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }
        public int? OrdersId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }

    public class OrderDetailInsertDTO
    {
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}