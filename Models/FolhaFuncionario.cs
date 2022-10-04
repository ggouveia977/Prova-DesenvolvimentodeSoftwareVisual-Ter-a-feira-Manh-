using System;
using System.Collections.Generic;


namespace API.Models
{
    public class FolhaFuncionario
    {
        public int Id { get; set; }
        public int FolhaId { get; set; }
        public string Cpf { get; set; }
        public string Mês { get; set; }
        public string Ano { get; set; }
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string CpfEmUso { get; set; }
        public double Salario { get; set; }
        public string Email { get; set; }
    

        
    }
}