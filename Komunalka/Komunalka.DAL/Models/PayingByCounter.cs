﻿using System;
using System.Collections.Generic;

namespace Komunalka.DAL.Models
{
    public partial class PayingByCounter
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public int ServiceProviderId { get; set; }
        public string Account { get; set; }
        public int CounterIndicationsCurrent { get; set; }
        public int CurrentIndicationsPrevious { get; set; }
        public int CounterIndicationsDifference { get; set; }
        public double RateCommon { get; set; }
        public double? RateDiscount { get; set; }
        public int? DiscountIndicationsAmount { get; set; }
        public decimal Summa { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
    }
}
