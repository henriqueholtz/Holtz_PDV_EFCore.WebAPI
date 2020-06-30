using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Domain;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Holtz_PDV_EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEFCoreRepo _repo;

        //public readonly EmpresaContext _context; //Add prop
        //public EmpresaController(EmpresaContext context)
        public EmpresaController(IEFCoreRepo repo) //Add ctor
        {
            _repo = repo;
            //_context = context;
        }
        // GET: api/<EmpresaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var empresas = await _repo.GetAllEmpresas();
                return Ok(empresas);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/Empresa
        [HttpPost]
        public async Task<IActionResult> Post(Empresa model)
        {
            try
            {
                //_context.Empresa.Add(model);
                //_context.SaveChanges();
                _repo.Add(model);
                if(await _repo.SaveChangeAsync())
                {
                    return Ok("OK");
                }
                else
                {
                    return Ok("Não localizado.");
                }
                
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex}");
            }
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{cod},{nome}")]
        public async Task<IActionResult> Put(int cod, string nome)
        {
            try
            {

                //if(_context.Empresa.AsNoTracking().FirstOrDefault(x => x.EmpCod == cod) != null) //Se usar Find no lugar do "AsNoTracking()", ele trava a conexão/consulta do banco { 
                //_context.Add(x);
                //_context.SaveChanges();}
                var empresa = new Empresa() { EmpCod = cod, EmpRaz = nome };
                _repo.Add(empresa);
                if(await _repo.SaveChangeAsync())
                {
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
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var empresa = new Empresa() { EmpCod = id };
                _repo.Delete(empresa);
                if(await _repo.SaveChangeAsync())
                {
                    return Ok("Deletado!" + empresa);
                }
                else
                {
                    return Ok("Não localizado!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}
