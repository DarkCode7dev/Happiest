using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApI.Data;
using WebApI.Models;

namespace WebApI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IRepository _repo;
        public DetailController(IRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Detail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Members>>> GetDetails()
        {
            return  await _repo.GetDetails();
        }


        // PUT: api/PaymentDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetail(int id, Members Detail)
        {
            if (id != Detail.GMId)
            {
                return BadRequest();
            }
           

            try
            {
                await _repo.PutDetail(id,Detail);
            }
            catch (Exception e)
            {
                throw e;
            }

            return NoContent();
        }

        // GET: api/Detail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Members>> GetDetail(int id)
        {
            var Detail = await _repo.GetDetail(id);

            if (Detail == null)
            {
                return NotFound();
            }

            return Detail;
        }

        // POST: api/Detail
        [HttpPost]
        public async Task<ActionResult<Members>> SaveDetail([FromBody]Members Detail)
        {
           var value= await _repo.PostDetail(Detail);
            if (value==0)
            {
                return BadRequest();
            }

            return await _repo.GetDetail(value);

        }
            

        // DELETE: api/Detail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Members>> DeleteDetail(int id)
        {
            var value = await _repo.GetDetail(id);
            var Detail = await _repo.DeleteDetail(id);
            if (Detail == false)
            {
                return NotFound();
            }
            return value;
            
        }

       
    }
}
