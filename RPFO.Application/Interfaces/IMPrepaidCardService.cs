﻿
using RPFO.Application.Helpers;
using RPFO.Data.Entities;
using RPFO.Data.ViewModel;
using RPFO.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RPFO.Application.Interfaces
{
    public interface IPrepaidCardService
    {
        Task<GenericResult> GetAll(string CompanyCode, string Status); 
        Task<GenericResult> GetByCode(string CompanyCode, string Code);
        Task<GenericResult> GetHistoryByCode(string CompanyCode, string Code);
        Task<GenericResult> Create(MPrepaidCard model);
        Task<GenericResult> Update(MPrepaidCard model);
        Task<GenericResult> Delete(string Code);
        Task<GenericResult> Import(DataImport model);
    }
}
