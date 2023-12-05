using MyEmplo.Application.Services;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Create(Domain.Entities.MyEmplo myEmplo)
        {
            await _myEmploService.Create(myEmplo);
            return RedirectToAction(nameof(Create));
        }
    }
}
