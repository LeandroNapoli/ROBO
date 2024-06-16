using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.Core.Enums
{
    public enum Rotacao
    {
        [Display(Name = "Rotação -90º")]
        Rotacao90Negativo = 1,
        [Display(Name = "Rotação -45º")]
        Rotacao45Negativo,
        [Display(Name = "Em Repouso")]
        EmRepouso,
        [Display(Name = "Rotação 45º")]
        Rotacao45,
        [Display(Name = "Rotação 90º")]
        Rotacao90,
        [Display(Name = "Rotação 135º")]
        Rotacao135,
        [Display(Name = "Rotação 180º")]
        Rotacao180
    }

    public enum RotacaoCabeca
    {
        [Display(Name = "Rotação -90º")]
        Rotacao90Negativo = 1,
        [Display(Name = "Rotação -45º")]
        Rotacao45Negativo,
        [Display(Name = "Em Repouso")]
        EmRepouso,
        [Display(Name = "Rotação 45º")]
        Rotacao45,
        [Display(Name = "Rotação 90º")]
        Rotacao90
    }
}