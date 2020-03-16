using Dominio;
using Infra.DBConfiguration.EFCore;
using Infra.Repositories.Standard.EFCore;
using Infraestrutura.Interfaces.Respositories.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Domain.EFCore
{
    public class AlunoRepository : RepositoryAsync<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Aluno>> GetAlunoByNome(string nome)
        {
            IQueryable<Aluno> query = await Task.FromResult(GenerateQuery(aluno => aluno.Nome.Contains(nome), null, nameof(Aluno)));
            return query.AsEnumerable();
        }
    }
}
