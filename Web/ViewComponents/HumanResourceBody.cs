using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class HumanResourceBody : ViewComponent
    {
        IPersonelService _personelService;
        public HumanResourceBody(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        public IViewComponentResult Invoke()
        {
            var res = _personelService.GetAllPersonelDetailHR();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }
    }
}