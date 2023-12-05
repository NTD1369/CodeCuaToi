﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPFO.Data.Entities
{
  public  class TPurchaseRequestHeader
    {
        public string PurchaseId { get; set; }
        public string CompanyCode { get; set; }
        public string StoreId { get; set; }
        public string StoreName { get; set; }
        public string DocStatus { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? DocDueDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string InvoiceAddress { get; set; }
        public string TaxCode { get; set; }
        public decimal? Vatpercent { get; set; }
        public decimal? Vattotal { get; set; }
        public decimal? DocTotal { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Status { get; set; }
        public string IsCanceled { get; set; }
        public string DocEntry { get; set; }
        public string DataSource { get; set; }
        public string SyncMWIStatus { get; set; }
        public string PRNum { get; set; }

        //Thêm vào để control được source Location
        public string Source { get; set; }
        public string TerminalId { get; set; }
        public string CustomF1 { get; set; }
        public string CustomF2 { get; set; }
        public string CustomF3 { get; set; }
        public string CustomF4 { get; set; }
        public string CustomF5 { get; set; }
    }
}