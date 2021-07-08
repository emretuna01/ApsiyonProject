using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Entities;
using PaymentService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly OperationServices _operationServices;

        public PaymentController(OperationServices operationServices)
        {
            _operationServices = operationServices;
        }

        [HttpGet]
        public async Task<List<Payment>> PaymentListAsync()
        {
            return await _operationServices.GetAllPaymentList();
        }
    }
}
