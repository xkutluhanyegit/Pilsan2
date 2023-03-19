using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("akulu-montaj")]
    public class BatteryInstallationController : Controller
    {
        private readonly ILogger<BatteryInstallationController> _logger;
        private readonly IVardiyaService _vardiyaService;

        public BatteryInstallationController(ILogger<BatteryInstallationController> logger, IVardiyaService vardiyaService)
        {
            _logger = logger;
            _vardiyaService = vardiyaService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("vardiya")]
        public IActionResult vardiya()
        {
            return View();
        }

        [HttpPost]
        public IActionResult add(List<VardiyaDetailListSectionByDep> vard, int shiftidvardiya)
        {
            Vardiya v = new Vardiya();
            for (int i = 0; i < vard.Count(); i++)
            {
                if (vard[i].check)
                {
                    v.ShiftCode = shiftidvardiya;
                    v.SicilNo = Convert.ToInt16(vard[i].SicilNo);
                    v.CreateDate = DateTime.Now.ToShortDateString();
                    v.WeeOfYear = (DateTime.Now.DayOfYear + 1) / 7;

                    _vardiyaService.Add(v);
                }
            }
            return RedirectToAction("vardiya", "batteryinstallation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}