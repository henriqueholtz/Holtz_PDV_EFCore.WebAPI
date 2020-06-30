using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Holtz_PDV_EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilialController : ControllerBase
    {
        public readonly IEFCoreRepo _repo;
        public FilialController(IEFCoreRepo repo)
        {
            _repo = repo;
        }
        // GET: api/<FilialController>
        [HttpGet("{ParEmpCod}")]
        public async Task<IActionResult> Get(int ParEmpCod)
        {
            try
            {
                var filiais = await _repo.GetAllFiliais(ParEmpCod);
                return Ok(filiais);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // GET api/<FilialController>/5
        [HttpGet("{ParEmpCod},{ParFilCod}")]
        public async Task<IActionResult> GetByCod(int ParEmpCod,int ParFilCod)
        {
            try
            {
                var filial = await _repo.GetFilialByCod(ParEmpCod, ParFilCod);
                return Ok(filial);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // POST api/<FilialController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FilialController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilialController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
