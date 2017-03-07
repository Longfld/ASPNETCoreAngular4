using Microsoft.AspNetCore.Mvc;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
         public HomeController(IHostingEnvironment hostingEnvironment, ILogger<HomeController> logger)
        {
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
           
        }
       
        
        public IActionResult Index()
        {
          _logger.LogError("HomeController: Helloworld from Index");
            return View();
        }
        
         private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILogger<HomeController> _logger;
    }
}
