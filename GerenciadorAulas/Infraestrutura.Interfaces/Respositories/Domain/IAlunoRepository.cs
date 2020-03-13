using Dominio;
using Infraestrutura.Interfaces.Respositories.Domain.Standard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces.Respositories.Domain
{
    public interface IAlunoRepository : IDomainRepository<Aluno>
    {
        Task<IEnumerable<Aluno>> GetAlunoByNome(string nome);
    }
}
