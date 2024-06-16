using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.Core.Enums
{
    public enum Inclinacao
    {
        [Display(Name = "Para Cima")]
        ParaCima = 1,
        [Display(Name = "Em Repouso")]
        EmRepouso,
        [Display(Name = "Para Baixo")]
        ParaBaixo
    }
}