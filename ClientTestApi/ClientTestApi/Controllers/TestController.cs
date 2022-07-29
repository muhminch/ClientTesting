using ClientTestApi.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyPolicy")]
    public class TestController : ControllerBase
    {
        private readonly InvoiceRespository _repo = null;

        public TestController(InvoiceDBContext _context)
        {
            this._repo = new InvoiceRespository(_context);
        }

        // GET: TestController
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                
                var data = await _repo.GetAllInvoiceDetails();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       
    }
}
