using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrnekPro.Data;
using OrnekPro.Models;

namespace OrnekPro.ViewComponent
{
    public class TurlerViewComponent: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTur = RouteData.Values["id"];
            return View (TurRepository.Turler);
        }
       
    }
}
