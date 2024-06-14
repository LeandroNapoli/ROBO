using R.O.B.O.Api.Domains.Abstracts;

namespace R.O.B.O.Api.Repositories.IRepositories
{
    public interface IRoboRepository
    {
        Task AtualizarMembros(IEnumerable<Membro> membro);
        Task<IEnumerable<Membro>> ObterMembros();
    }
}
