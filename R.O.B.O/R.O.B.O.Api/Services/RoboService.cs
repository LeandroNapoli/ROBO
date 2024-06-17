using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Repositories;
using R.O.B.O.Api.Repositories.IRepositories;
using R.O.B.O.Api.Services.IServices;
using R.O.B.O.Core.ViewModels;
using R.O.B.O.Core.Constants;

namespace R.O.B.O.Api.Services
{
    public class RoboService : IRoboService
    {
        private IRoboRepository _repository;

        public RoboService()
        {
            _repository = new RoboRepository();
        }

        public IEnumerable<MembroViewModel> AtualizarMembros(MembrosRobo membros) 
        { 
            _repository.AtualizarMembros(membros); 
            return ObterMembrosViewModel(membros);
        }

        public IEnumerable<MembroViewModel> ObterMembrosIniciais()
        {
            var membros = _repository.ObterMembros();
            return ObterMembrosViewModel(membros);
        }

        public IEnumerable<MembroViewModel> ObterMembrosViewModel(MembrosRobo membros)
        {
            var membrosViewModel = new HashSet<MembroViewModel>() 
            { 
                new MembroViewModel 
                { 
                    Nome = membros.Cabeca.Nome.ToString(), 
                    Estado = Constantes.DicionarioInclinacao[membros.Cabeca.Estado], 
                    Rotacao = Constantes.DicionarioRotacao[membros.Cabeca.Rotacao] 
                } 
            };

            foreach (var braco in membros.Bracos)
            {
                membrosViewModel.Add(new MembroViewModel 
                { 
                    Estado = Constantes.DicionarioEstadoCotovelo[braco.Cotovelo.Estado], 
                    Nome = braco.Cotovelo.Nome.ToString() 
                });

                membrosViewModel.Add(new MembroViewModel 
                { 
                    Nome = braco.Pulso.Nome.ToString(), 
                    Rotacao = Constantes.DicionarioRotacao[braco.Pulso.Rotacao] 
                });
            }

            return membrosViewModel;
        }
    }
}