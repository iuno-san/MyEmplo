using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyEmplo.Application.MyEmplo;
using MyEmplo.Application.MyEmplo.Commands.CreateMyEmplo;
using MyEmplo.Application.MyEmplo.Commands.EditMyEmplo;
using MyEmplo.Application.MyEmplo.Queries.GetAllMyEmplo;
using MyEmplo.Application.MyEmplo.Queries.GetMyEmploByEncodedName;

namespace MyEmplo.MVC.Controllers
{
    public class MyEmploController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MyEmploController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var myEmplos = await _mediator.Send(new GetAllMyEmploQuery());
            return View(myEmplos);
        }

        [Route("MyEmplo/{encodedName}/Details")]
        public async  Task<IActionResult> Details(string encodedName)
        {
            var dto = await _mediator.Send(new GetMyEmploByEncodedNameQuery(encodedName));

            return View(dto);
        }

        [Route("MyEmplo/{encodedName}/Edit")]
        public async Task<IActionResult> Edit(string encodedName)
        {
            var dto = await _mediator.Send(new GetMyEmploByEncodedNameQuery(encodedName));

            EditMyEmploCommand model = _mapper.Map<EditMyEmploCommand>(dto);

            return View(model);
        }

        [HttpPost]
        [Route("MyEmplo/{encodedName}/Edit")]
        public async Task<IActionResult> Edit(string encodedName, EditMyEmploCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult Create()
        {
            /*if(User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }*/

            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateMyEmploCommand command)
        {
            if(!ModelState.IsValid)
            {
                return View(command);
            }

            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
    }
}
