using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class Sidebarmenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}