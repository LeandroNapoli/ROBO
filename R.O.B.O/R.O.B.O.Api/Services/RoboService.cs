using R.O.B.O.Api.Domains.Abstracts;
using R.O.B.O.Api.Repositories;
using R.O.B.O.Api.Repositories.IRepositories;
using R.O.B.O.Api.Services.IServices;
using R.O.B.O.Api.ViewModels;

namespace R.O.B.O.Api.Services
{
    public class RoboService : IRoboService
    {
        private IRoboRepository _repository;

        public RoboService()
        {
            _repository = new RoboRepository();
        }
        public async Task AtualizarMembros(IEnumerable<Membro> membros) => await _repository.AtualizarMembros(membros);


        public async Task<IEnumerable<MembroViewModel>> ObterMembros()
        {
            var membros = await _repository.ObterMembros();
            var membrosViewModel = new HashSet<MembroViewModel>();

            foreach (var membro in membros)
            {
                membrosViewModel.Add(new MembroViewModel { Estado = membro.Estado.ToString(), Nome = membro.Nome.ToString(), Rotacao = membro.Rotacao.ToString() });
            }

            return membrosViewModel;
        }
    }
}