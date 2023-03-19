using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel, PilsanDatabaseContext>, IPersonelDal
    {
        public List<PersonelDetailHR> PersonelDetailHR()
        {
            using (var context = new PilsanDatabaseContext())
            {
                var result = from personel in context.Personels
                             join kimlik in context.Kimliks
                             on personel.Sicilno equals kimlik.Prsicil into t1
                             from personelKimlik in t1.DefaultIfEmpty()

                             join departman in context.Departmen
                             on personel.Depart equals departman.Kodu into t2
                             from personelDepartman in t2.DefaultIfEmpty()

                             join servis in context.Servis
                             on personel.Servis equals servis.Kodu into t3
                             from personelServis in t3.DefaultIfEmpty()

                             join durak in context.Duraks
                             on personel.Durak equals durak.DurakKodu into t4
                             from personelDurak in t4.DefaultIfEmpty()

                             join vardiya in context.Vardiyas
                             on personel.Sicilno equals vardiya.SicilNo into t5
                             from personelVardiya in t5.DefaultIfEmpty()

                             join shift in context.Shifts
                             on personelVardiya.ShiftCode equals shift.ShiftCode into t6
                             from personelVardiyaShift in t6.DefaultIfEmpty()

                             where personel.Iscikt == "NULL"

                             select new PersonelDetailHR
                             {
                                 SicilNo = personelKimlik.Prsicil.ToString(),
                                 TCKN = personelKimlik.Tckmno.ToString(),
                                 Departman = personelDepartman.Adi,
                                 Ad = personel.Adi,
                                 Soyad = personel.Soyadi,
                                 Servis = personelServis.Turu,
                                 Durak = personelDurak.DurakAdi,
                                 Vardiya = personelVardiyaShift.ShiftName


                             };


                return result.ToList();
            }
        }

        public List<PersonelDetailSectionByDep> PersonelDetailSectionByDep(string depId)
        {
            using (var context = new PilsanDatabaseContext())
            {
                var result = from personel in context.Personels
                             join vardiya in context.Vardiyas
                             on personel.Sicilno equals vardiya.SicilNo into t1
                             from personelVardiya in t1.DefaultIfEmpty()

                             join departman in context.Departmen
                             on personel.Depart equals departman.Kodu into t2
                             from personelDepartman in t2.DefaultIfEmpty()

                             join shift in context.Shifts
                             on personelVardiya.ShiftCode equals shift.ShiftCode into t3
                             from personelVardiyaShift in t3.DefaultIfEmpty()

                             where personel.Iscikt == "NULL" & personel.Depart == depId

                             select new PersonelDetailSectionByDep
                             {
                                 Ad = personel.Adi,
                                 Soyad = personel.Soyadi,
                                 Departman = personelDepartman.Adi,
                                 Vardiya = personelVardiyaShift.ShiftName
                             };

                return result.ToList();
            }
        }

        public List<VardiyaDetailListSectionByDep> VardiyaDetailListSectionByDep(string depId)
        {
            using (var context = new PilsanDatabaseContext())
            {
                var result = from personel in context.Personels
                             join vardiya in context.Vardiyas
                             on personel.Sicilno equals vardiya.SicilNo into t1
                             from personelVardiya in t1.DefaultIfEmpty()

                             where personel.Depart == depId & personel.Iscikt == "NULL"

                             select new VardiyaDetailListSectionByDep
                             {
                                 Ad = personel.Adi,
                                 Soyad = personel.Soyadi,
                                 SicilNo = personel.Sicilno.ToString(),
                                 ShiftCode = personelVardiya.ShiftCode.ToString(),
                                 WeekOfYear = Convert.ToInt32(personelVardiya.WeeOfYear)

                             };
                return result.ToList();
            }
        }
    }
}