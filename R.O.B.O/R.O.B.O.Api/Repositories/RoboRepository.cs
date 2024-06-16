using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Repositories.IRepositories;
using R.O.B.O.Core.Enums;

namespace R.O.B.O.Api.Repositories
{
    public class RoboRepository : IRoboRepository
    {
        private Braco _bracoDireito;
        private Braco _bracoEsquerdo;
        private Cabeca _cabeca;

        public RoboRepository() 
        {
            _bracoDireito = new Braco() { Nome = Membros.BracoDireito, Cotovelo = new Cotovelo() { Nome = Membros.CotoveloDireito }, Pulso = new Pulso() { Nome = Membros.PulsoDireito } };
            _bracoEsquerdo = new Braco() { Nome = Membros.BracoEsquerdo, Cotovelo = new Cotovelo() { Nome = Membros.CotoveloEsquerdo }, Pulso = new Pulso() { Nome = Membros.PulsoEsquerdo } };
            _cabeca = new Cabeca();        
        }

        public void AtualizarMembros(MembrosRobo membros)
        {
            var bracoDireito = membros.Bracos.FirstOrDefault(x => x.Nome == Membros.BracoDireito);
            var bracoEsquerdo = membros.Bracos.FirstOrDefault(x => x.Nome == Membros.BracoEsquerdo);
            var cabeca = membros.Cabeca;

            AtualizarBracoDireito(bracoDireito);

            AtualizarBracoEsquerdo(bracoEsquerdo);

            AtualizarCabeca(cabeca);
        }

        public MembrosRobo ObterMembros()
        {
            return new MembrosRobo
            {
                Bracos = new HashSet<Braco>() { _bracoDireito, _bracoEsquerdo },
                Cabeca = _cabeca
            };
        }

        private void AtualizarCabeca(Cabeca cabeca)
        {
            if (cabeca != null)
            {
                _cabeca.Rotacao = cabeca.Rotacao;
                _cabeca.Estado = cabeca.Estado;
            }
        }

        private void AtualizarBracoEsquerdo(Braco? bracoEsquerdo)
        {
            if (bracoEsquerdo != null)
            {
                _bracoEsquerdo.Cotovelo.Estado = bracoEsquerdo.Cotovelo.Estado;
                _bracoEsquerdo.Pulso.Rotacao = bracoEsquerdo.Pulso.Rotacao;
            }
        }

        private void AtualizarBracoDireito(Braco? bracoDireito)
        {
            if (bracoDireito != null)
            {
                _bracoDireito.Cotovelo.Estado = bracoDireito.Cotovelo.Estado;
                _bracoDireito.Pulso.Rotacao = bracoDireito.Pulso.Rotacao;
            }
        }

    }
}
