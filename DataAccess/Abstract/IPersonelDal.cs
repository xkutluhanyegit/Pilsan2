using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personel>
    {
        List<PersonelDetailHR> PersonelDetailHR();
        List<PersonelDetailSectionByDep> PersonelDetailSectionByDep(string depId);
        List<VardiyaDetailListSectionByDep> VardiyaDetailListSectionByDep(string depId);

    }
}

