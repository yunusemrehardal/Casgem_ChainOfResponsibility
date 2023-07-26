using Casgem_ChainOfResponsibility.ChainOfResposibilityPattern;
using Casgem_ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasure = new Treasure();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasure.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasure.ProcessRequest(model);

            return View();
        }
    }
}
