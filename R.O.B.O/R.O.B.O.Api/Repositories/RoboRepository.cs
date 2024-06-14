using R.O.B.O.Api.Domains.Abstracts;
using R.O.B.O.Api.Repositories.IRepositories;

namespace R.O.B.O.Api.Repositories
{
    public class RoboRepository : IRoboRepository
    {
        public Task AtualizarMembros(IEnumerable<Membro> membro)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Membro>> ObterMembros()
        {
            throw new NotImplementedException();
        }
    }
}
