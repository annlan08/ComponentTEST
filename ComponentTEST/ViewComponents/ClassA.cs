using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentTEST.ViewComponents
{
    public class ClassA:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string str ="GO fuck yourself";
            return View();
        }
    }
}
