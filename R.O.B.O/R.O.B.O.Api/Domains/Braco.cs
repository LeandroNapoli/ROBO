using R.O.B.O.Api.Domains.Abstracts;
using R.O.B.O.Api.Enums;

namespace R.O.B.O.Api.Domains
{
    public class Braco : Membro
    {
        public Braco()
        {
            Cotovelo = new Membro() { Nome = Membros.Cotovelo, Estado = (int)EstadoCotovelo.EmRepouso, Rotacao = (int)Enums.Rotacao.EmRepouso };
            Pulso = new Membro() { Nome = Membros.Pulso, Rotacao = (int)Enums.Rotacao.EmRepouso };
        }

        public Membro Cotovelo { get; set; }
        public Membro Pulso { get; set; }


        public void Rotacionar(int rotacao, Membro membro)
        {
            if (membro.Nome == Membros.Pulso)
                VerificarRotacaoPulso();

            if (VerificarRotacao(rotacao)) Rotacionar(rotacao);
            else
                throw new ArgumentException($"Não é possível rotacionar o {membro.Nome}, pois o estado selecionado não vem antes ou depois do estado atual");
        }

        public void VerificarRotacaoPulso()
        {
            if (Cotovelo.Estado != (int)EstadoCotovelo.FortementeContraido)
            {
                throw new ArgumentException($"O pulso não pode ser rotacionado, pois o estado atual do Cotovelo não é Fortemente Contraído");
            }
        }
    }
}