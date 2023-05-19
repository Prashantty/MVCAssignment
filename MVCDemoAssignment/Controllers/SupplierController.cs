using Microsoft.AspNetCore.Mvc;
using MVCDemoAssignment.Interfaces;
using MVCDemoAssignment.Models;

namespace MVCDemoAssignment.Controllers
{
    public class SupplierController : Controller
    {

        ISupplierInterface _sup;
        public SupplierController(ISupplierInterface sup)
        {
           _sup = sup;
        }
        public IActionResult Index()
        {
            return View(_sup.GetSupplier());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            _sup.Create(supplier);

            return RedirectToAction("Index");
        }


        public IActionResult Delete()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Delete(int id )
        {
             
            _sup.Delete(id );
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Edit(int id , Supplier supplier) 
        {
            _sup.Edit(id, supplier);
            return RedirectToAction("Index");
        }
    }
}
