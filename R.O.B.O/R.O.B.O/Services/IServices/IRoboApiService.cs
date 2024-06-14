using R.O.B.O.Domains;
using R.O.B.O.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.O.B.O.Services.IServices
{
    public interface IRoboApiService
    {
        Task AtualizarMembros(IEnumerable<Membro> membro);
        Task<IEnumerable<MembroViewModel>> ObterMembros();
    }
}
