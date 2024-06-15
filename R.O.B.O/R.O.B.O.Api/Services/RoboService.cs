using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Repositories;
using R.O.B.O.Api.Repositories.IRepositories;
using R.O.B.O.Api.Services.IServices;
using R.O.B.O.Core.ViewModels;

namespace R.O.B.O.Api.Services
{
    public class RoboService : IRoboService
    {
        private IRoboRepository _repository;

        public RoboService()
        {
            _repository = new RoboRepository();
        }
        public void AtualizarMembros(MembrosRobo membros) => _repository.AtualizarMembros(membros);


        public IEnumerable<MembroViewModel> ObterMembros()
        {
            var membros = _repository.ObterMembros();
            var membrosViewModel = new HashSet<MembroViewModel>() { new MembroViewModel { Nome = membros.Cabeca.Nome.ToString(), Estado = membros.Cabeca.Estado.ToString(), Rotacao = membros.Cabeca.Rotacao.ToString() } };

            foreach (var braco in membros.Bracos)
            {
                membrosViewModel.Add(new MembroViewModel { Estado = braco.Cotovelo.Estado.ToString(), Nome = braco.Cotovelo.Nome.ToString(), Rotacao = braco.Cotovelo.Rotacao.ToString() });
                membrosViewModel.Add(new MembroViewModel { Estado = braco.Pulso.Estado.ToString(), Nome = braco.Pulso.Nome.ToString(), Rotacao = braco.Pulso.Rotacao.ToString() });
            }


            return membrosViewModel;
        }
    }
}