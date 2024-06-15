using R.O.B.O.Core.Domains.Abstracts;
using R.O.B.O.Core.Enums;

namespace R.O.B.O.Core.Domains
{
    public class Cotovelo : Membro
    {
        public Cotovelo() { Estado = (int)EstadoCotovelo.EmRepouso; Rotacao = (int)Enums.Rotacao.EmRepouso; }
    }
}
