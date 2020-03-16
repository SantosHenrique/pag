using Application.Interfaces.Services.Standard;
using Application.Services.Standard;
using Dominio;
using Infraestrutura.Interfaces.Respositories.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Domain
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository; 

        public AlunoService(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public Task<IEnumerable<Aluno>> GetAlunoByNome(string nome)
        {
            return _alunoRepository.GetAlunoByNome(nome);
        }
    }
}
