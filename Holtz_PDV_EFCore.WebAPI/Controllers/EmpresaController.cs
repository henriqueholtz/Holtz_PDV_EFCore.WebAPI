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
    public class EmpresaController : ControllerBase
    {
        public readonly EmpresaContext _context; //Add prop
        public EmpresaController(EmpresaContext context) //Add ctor
        {
            _context = context;
        }
        // GET: api/<EmpresaController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                return Ok(new Empresa());
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
        public ActionResult Post(Empresa model)
        {
            try
            {
                
                _context.Empresa.Add(model);
                _context.SaveChanges();
                return Ok("BX");
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex}");
            }
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{cod}")]
        public ActionResult Put(int cod, Empresa x)
        {
            try
            {
                if(_context.Empresa.AsNoTracking().FirstOrDefault(x => x.EmpCod == cod) != null) //Se usar Find no lugar do "AsNoTracking()", ele trava a conexão/consulta do banco
                {
                    _context.Add(x);
                    _context.SaveChanges();
                    return Ok("Sucesso!");
                }
                else
                {
                    return BadRequest("Não encontrado! ");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }


        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
