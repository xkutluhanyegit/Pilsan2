using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class BatteryInstallationVardiyaLeftTable : ViewComponent
    {
        IPersonelService _personelService;
        public BatteryInstallationVardiyaLeftTable(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _personelService.VardiyaDetailListSectionByDep(DepartmanCode.BatteryInstallation);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}