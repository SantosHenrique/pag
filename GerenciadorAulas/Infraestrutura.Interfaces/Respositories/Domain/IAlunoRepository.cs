using Dominio;
using Infraestrutura.Interfaces.Respositories.Domain.Standard;
using Infraestrutura.Interfaces.Respositories.Standard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces.Respositories.Domain
{
    public interface IAlunoRepository : IRepositoryAsync<Aluno>
    {
        Task<IEnumerable<Aluno>> GetAlunoByNome(string nome);
    }
}
