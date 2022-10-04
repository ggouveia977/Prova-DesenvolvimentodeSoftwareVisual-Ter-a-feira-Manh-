using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;


namespace API.Controllers
{
    
    public class FolhasFuncionariosController : ControllerBase
    {
        private readonly DataContext _context;
        public FolhasFuncionariosController(DataContext context) => _context = context; 


        public void calcularSalarioFuncionario(Funcionario funcionario, FolhaPagamento folhaPagamento)
        {
            FolhaFuncionario folhaFuncionario = _context.FolhasFuncionarios.FirstOrDefault(f => f.FuncionarioId == funcionario.Id && f.FolhaId == folhaPagamento.Id);

           // if (folhaFuncionario != null)
            //{
              //  folhaFuncionario.Salario = 

            }

        }



}

