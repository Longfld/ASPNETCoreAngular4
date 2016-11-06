
   using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace webapp
{
    [Route("api/[controller]")]
    public class StaffController : Controller
    {

        [HttpGet("GetStaff")]
        public IActionResult GetStaff()
        {
            List<string> model = new List<string>();
            model.Add("John");
            model.Add("Jack");
            model.Add("Jane");
            model.Add("Matthew");
            model.Add("May");

            return Json(model);
        }
    }

}
