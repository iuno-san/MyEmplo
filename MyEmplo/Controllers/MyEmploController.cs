using MyEmplo.Application.Services;
using Microsoft.AspNetCore.Mvc;
using MyEmplo.Application.MyEmplo;

namespace MyEmplo.MVC.Controllers
{
    public class MyEmploController : Controller
    {
        private readonly IMyEmploService _myEmploService;

        public MyEmploController(IMyEmploService myEmploService)
        {
            _myEmploService = myEmploService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MyEmploDto myEmplo)
        {
            if(!ModelState.IsValid)
            {
                return View(myEmplo);
            }

            await _myEmploService.Create(myEmplo);
            return RedirectToAction(nameof(Create));
        }
    }
}
