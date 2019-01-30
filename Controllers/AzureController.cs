



using Microsoft.AspNetCore.Mvc;

namespace azure.Controllers
{
    [Route("[controller]")]
    public class AzureController : Controller
    {

        [HttpGet]
        public string GET()
        {

            return "Liaquat Ali";
        }

        [HttpPost]
        public string Add(int t)
        {
            return "value added";

        }


    }


}