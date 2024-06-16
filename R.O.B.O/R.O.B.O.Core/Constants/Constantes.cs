using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Extensions;
using System.Collections.Generic;

namespace R.O.B.O.Core.Constants
{
    public static class Constantes
    {
        public static Dictionary<int, string> DicionarioRotacao = new Dictionary<int, string>() {
            { (int)Rotacao.Rotacao90Negativo, Rotacao.Rotacao90Negativo.GetDisplayName() },
            { (int)Rotacao.Rotacao45Negativo, Rotacao.Rotacao45Negativo.GetDisplayName() },
            { (int)Rotacao.EmRepouso, Rotacao.EmRepouso.GetDisplayName() },
            { (int)Rotacao.Rotacao45, Rotacao.Rotacao45.GetDisplayName() },
            { (int)Rotacao.Rotacao90, Rotacao.Rotacao90.GetDisplayName() },
            { (int)Rotacao.Rotacao135, Rotacao.Rotacao135.GetDisplayName() },
            { (int)Rotacao.Rotacao180, Rotacao.Rotacao180.GetDisplayName() },
        };

        public static Dictionary<int, string> DicionarioInclinacao = new Dictionary<int, string>()
        {
            { (int)Inclinacao.ParaBaixo, Inclinacao.ParaBaixo.GetDisplayName() },
            { (int)Inclinacao.EmRepouso, Inclinacao.EmRepouso.GetDisplayName() },
            { (int)Inclinacao.ParaCima, Inclinacao.ParaCima.GetDisplayName() }
        };

        public static Dictionary<int, string> DicionarioEstadoCotovelo = new Dictionary<int, string>()
        {
            { (int)EstadoCotovelo.EmRepouso, EstadoCotovelo.EmRepouso.GetDisplayName() },
            { (int)EstadoCotovelo.LevementeContraido, EstadoCotovelo.LevementeContraido.GetDisplayName() },
            { (int)EstadoCotovelo.Contraido, EstadoCotovelo.Contraido.GetDisplayName() },
            { (int)EstadoCotovelo.FortementeContraido, EstadoCotovelo.FortementeContraido.GetDisplayName() }
        };        
        
        public static Dictionary<string, Rotacao> DicionarioRotacaoCamposTela = new Dictionary<string, Rotacao>() {
            { Rotacao.Rotacao90Negativo.GetDisplayName(), Rotacao.Rotacao90Negativo },
            { Rotacao.Rotacao45Negativo.GetDisplayName(), Rotacao.Rotacao45Negativo },
            { Rotacao.EmRepouso.GetDisplayName() , Rotacao.EmRepouso },
            { Rotacao.Rotacao45.GetDisplayName() , Rotacao.Rotacao45 },
            { Rotacao.Rotacao90.GetDisplayName() , Rotacao.Rotacao90 },
            { Rotacao.Rotacao135.GetDisplayName() , Rotacao.Rotacao135 },
            { Rotacao.Rotacao180.GetDisplayName() , Rotacao.Rotacao180 },
        };

        public static Dictionary<string, Inclinacao> DicionarioInclinacaoCamposTela = new Dictionary<string, Inclinacao>()
        {
            { Inclinacao.ParaBaixo.GetDisplayName() , Inclinacao.ParaBaixo },
            { Inclinacao.EmRepouso.GetDisplayName() , Inclinacao.EmRepouso },
            { Inclinacao.ParaCima.GetDisplayName() , Inclinacao.ParaCima }
        };

        public static Dictionary<string, EstadoCotovelo> DicionarioEstadoCotoveloCamposTela = new Dictionary<string, EstadoCotovelo>()
        {
            { EstadoCotovelo.EmRepouso.GetDisplayName() , EstadoCotovelo.EmRepouso },
            { EstadoCotovelo.LevementeContraido.GetDisplayName() , EstadoCotovelo.LevementeContraido },
            { EstadoCotovelo.Contraido.GetDisplayName() , EstadoCotovelo.Contraido },
            { EstadoCotovelo.FortementeContraido.GetDisplayName() , EstadoCotovelo.FortementeContraido }
        };

        public static Dictionary<Membros, Membros> DicionarioCotoveloCriacaoBraco = new Dictionary<Membros, Membros>()
        {
            {Membros.BracoDireito, Membros.CotoveloDireito },
            {Membros.BracoEsquerdo, Membros.CotoveloEsquerdo },
        };   
        
        public static Dictionary<Membros, Membros> DicionarioPulsoCriacaoBraco = new Dictionary<Membros, Membros>()
        {
            {Membros.BracoDireito, Membros.PulsoDireito },
            {Membros.BracoEsquerdo, Membros.PulsoEsquerdo },
        };
    }
}
