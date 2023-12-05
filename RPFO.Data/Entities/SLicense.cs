﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RPFO.Data.Entities
{
    public partial class SLicense
    {
        public string LicenseId { get; set; }
        public string CompanyCode { get; set; }
        public string LicenseType { get; set; }
        public string LicenseDesc { get; set; }
        public string LicenseCode { get; set; }
     
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string Status { get; set; }
        public decimal? LicenseAmt { get; set; }
        public decimal? NumOfDevice { get; set; }
        public decimal? LicenseRemain { get; set; }
        public string Token { get; set; }
        public string CustomF1 { get; set; }
        public string CustomF2 { get; set; }
        public string CustomF3 { get; set; }
        public string CustomF4 { get; set; }
        public string CustomF5 { get; set; }
        public string CustomF6 { get; set; }
        public string CustomF7 { get; set; }
        public string CustomF8 { get; set; }
        public string CustomF9 { get; set; }
        public string CustomF10 { get; set; }
        public string CustomF11 { get; set; }
        public string CustomF12 { get; set; }
        public string CustomF13 { get; set; }
        public string CustomF14 { get; set; }
        public string CustomF15 { get; set; }
        public string LicenseCusF1 { get; set; }
        public string LicenseCusF2 { get; set; }
        public string LicenseCusF3 { get; set; }
        public string LicenseCusF4 { get; set; }
        public string LicenseCusF5 { get; set; }
        public int? ExpiredNumber { get; set; }


        public string MergeToken
        {
            get
            {

                string result = "";
                if (!string.IsNullOrEmpty(CustomF1)) result += CustomF1;
                if (!string.IsNullOrEmpty(CustomF2)) result += CustomF2;
                if (!string.IsNullOrEmpty(CustomF3)) result += CustomF3;
                if (!string.IsNullOrEmpty(CustomF4)) result += CustomF4;
                if (!string.IsNullOrEmpty(CustomF5)) result += CustomF5;
                if (!string.IsNullOrEmpty(CustomF6)) result += CustomF6;
                if (!string.IsNullOrEmpty(CustomF7)) result += CustomF7;
                if (!string.IsNullOrEmpty(CustomF8)) result += CustomF8;
                if (!string.IsNullOrEmpty(CustomF9)) result += CustomF9;
                if (!string.IsNullOrEmpty(CustomF10)) result += CustomF10;
                if (!string.IsNullOrEmpty(CustomF11)) result += CustomF11;
                if (!string.IsNullOrEmpty(CustomF12)) result += CustomF12;
                if (!string.IsNullOrEmpty(CustomF13)) result += CustomF13;
                if (!string.IsNullOrEmpty(CustomF14)) result += CustomF14;
                if (!string.IsNullOrEmpty(CustomF15)) result += CustomF15;


                return result;
            }
        }
        public int? NotifyShowOn { get; set; } = 7;

        public List<MUserLicense> Users { get; set; }

        public LicenseInfor LicenseInfor { get; set; }
    }
    public class LicenseInfor
    {
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string ContractNo { get; set; }
        public string LicenseType { get; set; } = "";
        public string LicenseNo { get; set; } = "";

        public string Description { get; set; } = "";
        public int NumOfDevice { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string CustomF1 { get; set; } = "";
        public string CustomF2 { get; set; } = "";
        public string CustomF3 { get; set; } = "";
        public string CustomF4 { get; set; } = "";
        public string CustomF5 { get; set; } = "";
        public string GMT { get; set; } = "";
        public int? NotifyShowOn { get; set; } = 7;
    }
}
