using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyEmplo.Application.MyEmplo;
using MyEmplo.Application.MyEmplo.Commands.CreateMyEmplo;
using MyEmplo.Application.MyEmplo.Queries.GetAllMyEmplo;
using MyEmplo.Application.MyEmplo.Queries.GetMyEmploByEncodedName;

namespace MyEmplo.MVC.Controllers
{
    public class MyEmploController : Controller
    {
        private readonly IMediator _mediator;

        public MyEmploController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var myEmplos = await _mediator.Send(new GetAllMyEmploQuery());
            return View(myEmplos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [Route("MyEmplo/{encodedName}/Details")]
        public async  Task<IActionResult> Details(string encodedName)
        {
            var dto = await _mediator.Send(new GetMyEmploByEncodedNameQuery(encodedName));
            return View(dto);
        } 

        [HttpPost]
        public async Task<IActionResult> Create(CreateMyEmploCommand command)
        {
            if(!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            return RedirectToAction(nameof(Create));
        }
    }
}
