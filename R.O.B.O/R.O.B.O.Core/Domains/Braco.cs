using R.O.B.O.Core.Enums;

namespace R.O.B.O.Core.Domains
{
    public class Braco
    {
        public Membros Nome { get; set; } 

        public Braco()
        {
            Cotovelo = new Cotovelo();
            Pulso = new Pulso();
        }

        public Cotovelo Cotovelo { get; set; }
        public Pulso Pulso { get; set; }
    }
}