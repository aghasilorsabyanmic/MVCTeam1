using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet5.Controllers
{
    public class BaseMvcController :Controller
    {
        public BaseMvcController() : base()
        {
            ViewData["menu"] = new List<string>();
        }
    }
}
