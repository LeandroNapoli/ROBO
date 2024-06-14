using R.O.B.O.Api.Domains.Abstracts;

namespace R.O.B.O.Api.Repositories.IRepositories
{
    public interface IRoboRepository
    {
        void AtualizarMembros(IEnumerable<Membro> membro);
        HashSet<Membro> ObterMembros();
    }
}
