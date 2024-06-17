using R.O.B.O.Core.Domains.Abstracts;
using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Extensions;
using System;

namespace R.O.B.O.Core.Domains
{
    public class Pulso : Membro
    {
        public Pulso() { Rotacao = (int)Enums.Rotacao.EmRepouso; }
        public void VerificarRotacaoPulso(int estadoCotovelo, Membros cotovelo)
        {
            if (estadoCotovelo != (int)EstadoCotovelo.FortementeContraido)
            {
                throw new ArgumentException($"O pulso não pode ser rotacionado, pois o estado atual do {cotovelo.ObterDisplayName()} não é Fortemente Contraído");
            }
        }
    }
}
