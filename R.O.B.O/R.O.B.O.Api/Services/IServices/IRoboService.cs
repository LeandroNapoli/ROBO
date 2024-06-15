using R.O.B.O.Core.ViewModels;
using R.O.B.O.Core.Domains;

namespace R.O.B.O.Api.Services.IServices
{
    public interface IRoboService
    {
        IEnumerable<MembroViewModel> ObterMembros();
        void AtualizarMembros(MembrosRobo membro);
    }
}
