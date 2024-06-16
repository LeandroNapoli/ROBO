using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Repositories;
using R.O.B.O.Api.Repositories.IRepositories;
using R.O.B.O.Api.Services.IServices;
using R.O.B.O.Core.ViewModels;
using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Extensions;

namespace R.O.B.O.Api.Services
{
    public class RoboService : IRoboService
    {
        private IRoboRepository _repository;

        #region Dicionarios
        private Dictionary<int, string> _dicionarioRotacao = new Dictionary<int, string>() {
            { (int)Rotacao.Rotacao90Negativo, Rotacao.Rotacao90Negativo.GetDisplayName() },
            { (int)Rotacao.Rotacao45Negativo, Rotacao.Rotacao45Negativo.GetDisplayName() },
            { (int)Rotacao.EmRepouso, Rotacao.EmRepouso.GetDisplayName() },
            { (int)Rotacao.Rotacao45, Rotacao.Rotacao45.GetDisplayName() },
            { (int)Rotacao.Rotacao90, Rotacao.Rotacao90.GetDisplayName() },
            { (int)Rotacao.Rotacao135, Rotacao.Rotacao135.GetDisplayName() },
            { (int)Rotacao.Rotacao180, Rotacao.Rotacao180.GetDisplayName() },
        };

        private Dictionary<int, string> _dicionarioInclinacao = new Dictionary<int, string>()
        {
            { (int)Inclinacao.ParaBaixo, Inclinacao.ParaBaixo.GetDisplayName() },
            { (int)Inclinacao.EmRepouso, Inclinacao.EmRepouso.GetDisplayName() },
            { (int)Inclinacao.ParaCima, Inclinacao.ParaCima.GetDisplayName() } 
        };        
        
        private Dictionary<int, string> _dicionarioEstadoCotovelo = new Dictionary<int, string>()
        {
            { (int)EstadoCotovelo.EmRepouso, EstadoCotovelo.EmRepouso.GetDisplayName() },
            { (int)EstadoCotovelo.LevementeContraido, EstadoCotovelo.LevementeContraido.GetDisplayName() },
            { (int)EstadoCotovelo.Contraido, EstadoCotovelo.Contraido.GetDisplayName() },
            { (int)EstadoCotovelo.FortementeContraido, EstadoCotovelo.FortementeContraido.GetDisplayName() }
        };

        #endregion

        public RoboService()
        {
            _repository = new RoboRepository();
        }
        public void AtualizarMembros(MembrosRobo membros) => _repository.AtualizarMembros(membros);


        public IEnumerable<MembroViewModel> ObterMembros()
        {
            var membros = _repository.ObterMembros();
            var membrosViewModel = new HashSet<MembroViewModel>() { new MembroViewModel { Nome = membros.Cabeca.Nome.ToString(), Estado = _dicionarioInclinacao[membros.Cabeca.Estado], Rotacao = _dicionarioRotacao[membros.Cabeca.Rotacao] } };

            foreach (var braco in membros.Bracos)
            {
                membrosViewModel.Add(new MembroViewModel { Estado = _dicionarioEstadoCotovelo[braco.Cotovelo.Estado], Nome = braco.Cotovelo.Nome.ToString() });
                membrosViewModel.Add(new MembroViewModel { Nome = braco.Pulso.Nome.ToString(), Rotacao = _dicionarioRotacao[braco.Pulso.Rotacao] });
            }


            return membrosViewModel;
        }
    }
}