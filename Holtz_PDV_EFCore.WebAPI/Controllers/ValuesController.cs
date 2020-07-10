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
        private readonly IEFCoreRepo _repo;
        //public readonly EmpresaContext _context;
        public ValuesController(IEFCoreRepo repo) //Add ctor
        {
            _repo = repo;
            //_context = context;
        }
        //public ValuesController(EmpresaContext context)
        //{
        //    _context = context;
        //}
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
            //var listEmpresa = _repo.Empresa
            //                  //.Where(x => x.EmpRaz.Contains(razao))
            //                  .Where(y=> EF.Functions.Like(y.EmpRaz, $"%{razao}%"))
            //                  .OrderBy(z => z.EmpCod)
            //                  .ToList(); 
            return Ok(/*listEmpresa*/);
        }
        /*
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<ValuesController>
        [HttpPost("Inserir/{OqueFazer}")]
        public async Task<IActionResult> Post(int OqueFazer)
        {
            try
            {
                switch(OqueFazer)
                {
                    case 1:
                        var empresa1 = new Empresa() { EmpCod = 1, EmpRaz = "JASPI SISTEMAS", EmpFan = "JASPI", EmpCpfCnpj = "12.123.456/0001-55", EmpSts = Enums.Status_AtivoInativo.ATIVO };
                        var empresa2 = new Empresa() { EmpCod = 2, EmpRaz = "WESTSELLER RZÃO", EmpFan = "WESTSELLER", EmpCpfCnpj = "65.432.210/0001-55", EmpSts = Enums.Status_AtivoInativo.ATIVO };
                        _repo.Add(empresa1);
                        _repo.Add(empresa2);
                        await _repo.SaveChangeAsync();
                        break;

                    case 2:
                        var usuario1 = new Usuario() { UsuCod = 1, UsuNom = "HENRIQUE", UsuSts = Enums.Status_AtivoInativo.ATIVO, UsuTip = 0 };
                        var usuario2 = new Usuario() { UsuCod = 2, UsuNom = "JOAO", UsuSts = Enums.Status_AtivoInativo.ATIVO, UsuTip = 0 };
                        _repo.Add(usuario1);
                        _repo.Add(usuario2);
                        await _repo.SaveChangeAsync();
                        break;

                    case 3:
                        var filial1 = new Filial() { EmpCod = 1, FilCod = 1, FilRaz = "JASPI SISTEMAS FILIAL", FilFan = "JASPI FILIAL" };
                        var filial2 = new Filial() { EmpCod = 2, FilCod = 1, FilRaz = "WESTSELLER RZÃO FILIAL", FilFan = "WESTSELLER FILIAL" };
                        _repo.Add(filial1);
                        _repo.Add(filial2);
                        await _repo.SaveChangeAsync();
                        break;
                    case 4:
                        var usuarioempresas1 = new UsuarioEmpresas() { EmpCod = 1, UsuCod = 1 };
                        var usuarioempresas2 = new UsuarioEmpresas() { EmpCod = 2, UsuCod = 1 };
                        var usuarioempresas3 = new UsuarioEmpresas() { EmpCod = 1, UsuCod = 2 };
                        _repo.Add(usuarioempresas1);
                        _repo.Add(usuarioempresas2);
                        _repo.Add(usuarioempresas3);
                        await _repo.SaveChangeAsync();
                        break;
                }
                return Ok("Tudo certo fih");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

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
