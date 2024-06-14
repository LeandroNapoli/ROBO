using R.O.B.O.Api.ViewModels;
using R.O.B.O.Api.Domains.Abstracts;

namespace R.O.B.O.Api.Services.IServices
{
    public interface IRoboService
    {
        Task<IEnumerable<MembroViewModel>> ObterMembros();
        Task AtualizarMembros(IEnumerable<Membro> membro);
    }
}
