using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;
        public FolhaController(DataContext context) =>
            _context = context;

        // GET: /api/folha/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Folhas.ToList());

        // POST: /api/folha/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] FolhaPagamento folhaPagamento)
        {
            _context.Folhas.Add(folhaPagamento);
            _context.SaveChanges();
            return Created("", folhaPagamento);
        }

        // GET: /api/folha/buscar/{cpf}/{mês}/{ano}
        [HttpGet]
        [Route("buscar/cpf/mês/ano")]
        public IActionResult Buscar([FromRoute] string cpf, string mes, string ano)
        {
            FolhaPagamento folhaPagamento = _context.Folhas.
                FirstOrDefault(folha => folha.Cpf.Equals(cpf) &&
                folha.Mês.Equals(mes) &&
                folha.Ano.Equals(ano));
            return folhaPagamento != null ? Ok(folhaPagamento) : NotFound();
        } 
    }
}