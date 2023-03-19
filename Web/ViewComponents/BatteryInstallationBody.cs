using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class BatteryInstallationBody : ViewComponent
    {
        IPersonelService _personelService;
        public BatteryInstallationBody(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _personelService.PersonelDetailSectionByDep(DepartmanCode.BatteryInstallation);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}