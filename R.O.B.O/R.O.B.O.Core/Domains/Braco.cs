using R.O.B.O.Core.Enums;

namespace R.O.B.O.Core.Domains
{
    public class Braco
    {
        public Membros Nome { get; set; } 

        public Braco()
        {
            Cotovelo = new Cotovelo() { Estado = (int)EstadoCotovelo.EmRepouso, Rotacao = (int)Rotacao.EmRepouso };
            Pulso = new Pulso() { Rotacao = (int)Rotacao.EmRepouso };
        }

        public Cotovelo Cotovelo { get; set; }
        public Pulso Pulso { get; set; }
    }
}