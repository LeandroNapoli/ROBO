using R.O.B.O.Api.Domains.Abstracts;
using R.O.B.O.Api.Enums;

namespace R.O.B.O.Domains
{
    public class Braco : Membro
    {
        public Membro Cotovelo
        {
            get { return Cotovelo; }
            set 
            {
                Cotovelo.Nome = Membros.Cotovelo;
                Cotovelo.Estado = (int)EstadoCotovelo.EmRepouso; 
                Cotovelo.Rotacao = (int)Api.Enums.Rotacao.EmRepouso; 
            }
        }
        public Membro Pulso
        {
            get { return Pulso; }
            set
            {
                Pulso.Nome = Membros.Pulso;
                Pulso.Rotacao = (int)Api.Enums.Rotacao.EmRepouso;
            }
        }

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
            if(Cotovelo.Estado != (int)EstadoCotovelo.FortementeContraido)
            {
                throw new ArgumentException($"O pulso não pode ser rotacionado, pois o estado atual do Cotovelo não é Fortemente Contraído");
            }
        }
    }
}