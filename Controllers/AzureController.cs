



using Microsoft.AspNetCore.Mvc;

namespace azure.Controllers
{
    [Route("[controller]")]
    public class AzureController : Controller
    {

        [HttpGet]
        public string GET()
        {

            return "Ch Liaquat Ali Tahir";
        }

        [HttpPost]
        public string Add(int t)
        {
            return "value added";

        }


    }


}