using R.O.B.O.Core.ViewModels;
using R.O.B.O.Core.Domains;

namespace R.O.B.O.Api.Services.IServices
{
    public interface IRoboService
    {
        IEnumerable<MembroViewModel> ObterMembrosIniciais();
        IEnumerable<MembroViewModel> AtualizarMembros(MembrosRobo membro);
        IEnumerable<MembroViewModel> ObterMembrosViewModel(MembrosRobo membros);
    }
}
