using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<List<Personel>> GetAll()
        {
            var result = _personelDal.GetAll().Where(p => p.Iscikt == "NULL").ToList();
            return new SuccessDataResult<List<Personel>>(result);
        }

        public IDataResult<List<PersonelDetailHR>> GetAllPersonelDetailHR()
        {
            var result = _personelDal.PersonelDetailHR();
            return new SuccessDataResult<List<PersonelDetailHR>>(result);

        }

        public IDataResult<List<PersonelDetailSectionByDep>> PersonelDetailSectionByDep(string depId)
        {
            var result = _personelDal.PersonelDetailSectionByDep(depId);
            return new SuccessDataResult<List<PersonelDetailSectionByDep>>(result);
        }

        public IDataResult<List<VardiyaDetailListSectionByDep>> VardiyaDetailListSectionByDep(string depId)
        {
            int week = (DateTime.Now.DayOfYear + 1) / 7; //Cuma Resetlenir
            var res = _personelDal.VardiyaDetailListSectionByDep(DepartmanCode.BatteryInstallation);

            var group = from r in res
                        group r by r.SicilNo into g
                        select new VardiyaDetailListSectionByDep
                        {
                            SicilNo = g.Key,
                            Ad = g.Select(p => p.Ad).First(),
                            ShiftCode = g.Select(p => p.ShiftCode).First(),
                            Soyad = g.Select(p => p.Soyad).First(),
                            WeekOfYear = g.Select(p => p.WeekOfYear).Max(),
                        };


            var result = group.Where(p => p.WeekOfYear != week).ToList();
            return new SuccessDataResult<List<VardiyaDetailListSectionByDep>>(result.ToList());
        }
    }
}