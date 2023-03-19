using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<List<Personel>> GetAll();
        IDataResult<List<PersonelDetailHR>> GetAllPersonelDetailHR();
        IDataResult<List<PersonelDetailSectionByDep>> PersonelDetailSectionByDep(string depId);
        IDataResult<List<VardiyaDetailListSectionByDep>> VardiyaDetailListSectionByDep(string depId);

    }
}