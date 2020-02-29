using Dominio.Interfaces;
using System;

namespace Dominio.Entidades
{
    public class Aluno : IEntidadeIdentidade
    {
        public int Id { get; set; }
        public DateTime Insercao { get; set; }
        public DateTime Atualizacao { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
