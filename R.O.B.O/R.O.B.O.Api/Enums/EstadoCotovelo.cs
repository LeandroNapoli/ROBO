using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.Api.Enums
{
    public enum EstadoCotovelo
    {
        [Display(Name = "Em Repouso")]
        EmRepouso = 1,
        [Display(Name = "Levemente Contraído")]
        LevementeContraido,
        [Display(Name = "Contraído")]
        Contraido,
        [Display(Name = "Fortemente Contraído")]
        FortementeContraido
    }
}