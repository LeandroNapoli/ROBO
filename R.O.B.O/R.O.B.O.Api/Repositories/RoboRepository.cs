using R.O.B.O.Api.Domains;
using R.O.B.O.Api.Domains.Abstracts;
using R.O.B.O.Api.Repositories.IRepositories;

namespace R.O.B.O.Api.Repositories
{
    public class RoboRepository : IRoboRepository
    {
        private Braco _bracoDireito;
        private Braco _bracoEsquerdo;
        private Cabeca _cabeca;

        public RoboRepository() 
        {
            _bracoDireito = new Braco() { Nome = Enums.Membros.BracoDireito};
            _bracoEsquerdo = new Braco() { Nome = Enums.Membros.BracoEsquerdo }; 
            _cabeca = new Cabeca();
        }

        public void AtualizarMembros(IEnumerable<Membro> membro)
        {
            var bracoDireito = membro.FirstOrDefault(x => x.Nome == Enums.Membros.BracoDireito);
            var bracoEsquerdo = membro.FirstOrDefault(x => x.Nome == Enums.Membros.BracoEsquerdo);
            var cabeca = membro.FirstOrDefault(x => x.Nome == Enums.Membros.Cabeca);

            _bracoDireito.Rotacao = bracoDireito.Rotacao;
            _bracoDireito.Estado = bracoDireito.Estado;

            _bracoEsquerdo.Rotacao = bracoEsquerdo.Rotacao;
            _bracoEsquerdo.Estado = bracoEsquerdo.Estado;

            _cabeca.Rotacao = cabeca.Rotacao;
            _cabeca.Estado = cabeca.Estado;
        }

        public HashSet<Membro> ObterMembros()
        {
            return new HashSet<Membro>
            {
                _bracoDireito,
                _bracoEsquerdo,
                _cabeca
            };
        }
    }
}
