using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Domain;
using EFCore.Enums;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Holtz_PDV_EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //public readonly EmpresaContext _context;
        //public UsuarioController(EmpresaContext context)
        //{
        //    _context = context;
        //}
        public readonly IEFCoreRepo _repo;
        public UsuarioController(IEFCoreRepo repo)
        {
            _repo = repo;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{cod}")]
        public async Task<IActionResult> Get(int cod)
        {
            try
            {
                var usuario = await _repo.GetUsuarioByCod(cod);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // POST api/<UsuarioController>
        [HttpPost("{cod},{nome}")]
        public async Task<IActionResult> Post(int cod,string nome)
        {
            try
            {
                var usuario = new Usuario() { UsuCod = cod, UsuNom = nome, UsuSts = Enums.Status_AtivoInativo.ATIVO};
                _repo.Add(usuario);
                if(await _repo.SaveChangeAsync())
                {
                    return Ok(usuario);
                }
                else
                {
                    return BadRequest("Não Encontrado!");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await _repo.GetUsuarioByCod(id);
                _repo.Delete(user);
                if (await _repo.SaveChangeAsync())
                {
                    return Ok("Deletado: " + user);
                }
                else
                {
                    return Ok("Não localizado!");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
