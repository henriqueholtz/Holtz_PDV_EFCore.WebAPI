using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Domain;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Holtz_PDV_EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly EmpresaContext _context;
        public ValuesController(EmpresaContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("filtro/{razao}")]
        public ActionResult Get(string razao)
        {

            //primary option
            /*var listEmpresa = (from empresa in _context.Empresa
                               where empresa.EmpRaz.Contains(razao) //Where:
                               select empresa).ToList();*/

            //secondary option
            var listEmpresa = _context.Empresa
                              //.Where(x => x.EmpRaz.Contains(razao))
                              .Where(y=> EF.Functions.Like(y.EmpRaz, $"%{razao}%"))
                              .OrderBy(z => z.EmpCod)
                              .ToList(); 
            return Ok(listEmpresa);
        }
        /*
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
