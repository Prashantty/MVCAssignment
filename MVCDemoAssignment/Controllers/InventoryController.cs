using Microsoft.AspNetCore.Mvc;
using MVCDemoAssignment.Interfaces;
using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Controllers
{
    public class InventoryController : Controller
    {

        IInventoryInterface _inf;

        public InventoryController(IInventoryInterface inf)
        {
            _inf = inf;
        }
        public IActionResult Index()
        {
            return View(_inf.GetInvantory());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Inventory inventory)
        {
            _inf.Create(inventory);

            return RedirectToAction("Index");
        }
    }
}
