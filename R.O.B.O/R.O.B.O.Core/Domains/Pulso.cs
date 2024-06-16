using R.O.B.O.Core.Domains.Abstracts;
using R.O.B.O.Core.Enums;
using System;

namespace R.O.B.O.Core.Domains
{
    public class Pulso : Membro
    {
        public Pulso() { Rotacao = (int)Enums.Rotacao.EmRepouso; }
        public void VerificarRotacaoPulso(int estadoCotovelo)
        {
            if (estadoCotovelo != (int)EstadoCotovelo.FortementeContraido)
            {
                throw new ArgumentException($"O pulso não pode ser rotacionado, pois o estado atual do Cotovelo não é Fortemente Contraído");
            }
        }
    }
}
