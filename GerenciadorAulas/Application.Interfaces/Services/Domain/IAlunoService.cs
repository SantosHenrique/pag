using Dominio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.Standard
{
    public interface IAlunoService : IServiceBase<Aluno>
    {
        Task<IEnumerable<Aluno>> GetAlunoByNome(string nome);
    }
}
