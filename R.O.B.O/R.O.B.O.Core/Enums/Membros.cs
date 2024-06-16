using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.Core.Enums
{
    public enum Membros
    {
        [Display(Name = "Cotovelo Direito")]
        CotoveloDireito,
        [Display(Name = "Cotovelo Esquerdo")]
        CotoveloEsquerdo,
        PulsoDireito,
        PulsoEsquerdo,
        Cabeca,
        BracoEsquerdo,
        BracoDireito
    }
}