using R.O.B.O.Core.Domains.Abstracts;
using R.O.B.O.Core.Enums;
using System;

namespace R.O.B.O.Core.Domains
{
    public class Cabeca : Membro
    {
        public Cabeca()
        {
            Nome = Membros.Cabeca;
            Estado = (int)Inclinacao.EmRepouso;
            Rotacao = (int)Enums.Rotacao.EmRepouso;
        }

        public bool VerificarRotacaoCabeca(int rotacao)
        {
            if (Estado != (int)Inclinacao.ParaBaixo)
            {
                return VerificarRotacao(rotacao);
            }
            else
                throw new ArgumentException($"A cabeça não pode ser rotacionada, pois sua inclinação está para baixo!");
        }
    }
}