
using Microsoft.AspNetCore.Mvc;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("/api/Pay")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IVnPayServiceRepo _vnPayService;

        public PaymentController(IVnPayServiceRepo vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [HttpPost]
        [Route("/api/Pay/Create")]
        public IActionResult CreatePaymentUrl(PaymentInformationDTO model)
        {
            var url = _vnPayService.CreatePaymentUrl(model, HttpContext);

            return Ok(url);
        }
    }
}
