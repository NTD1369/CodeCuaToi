﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RPFO.Data.Entities
{
    public partial class TCapacityTransaction
    {
        public string CompanyCode { get; set; }
        public string TransId { get; set; }
        public string StoreId { get; set; }
        public string StoreAreaId { get; set; }
        public string TimeFrameId { get; set; }
        public DateTime TransDate { get; set; }
        public string ItemCode { get; set; }
        public int? CapacityValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModififedOn { get; set; }
        public string Status { get; set; }
    }
}
