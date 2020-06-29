using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Domain;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Holtz_PDV_EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        public readonly EmpresaContext _context;
        public EmpresaController(EmpresaContext context)
        {
            _context = context;
        }
        // GET: api/<EmpresaController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/Empresa
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                var empresa = new Empresa
                {
                    EmpRaz = "EMPRESA X"
                    
                };

                _context.Empresa.Add(empresa);
                _context.SaveChanges();
                return Ok("BX");
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex}");
            }
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
