using MeuSite2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuSite2.Controllers
{
    public class CustomerMovementsController : Controller
    {

        private readonly CustomerMovements _customerMovements;

        public CustomerMovementsController(CustomerMovements context)
        {
            _customerMovements = context;
        }

        public IActionResult Index()
        {
            var list = _customerMovements.BuscarTodos();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(CustomerMovements customerMovements)
        {

            _customerMovements.Insert(customerMovements);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _customerMovements.Delete(id.Value);
            
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Guid id)
        {
            _customerMovements.Remove(id);
            return RedirectToAction(nameof(Index));
               
        }


    }
}


