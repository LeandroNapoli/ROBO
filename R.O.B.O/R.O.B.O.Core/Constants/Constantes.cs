using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Extensions;
using System.Collections.Generic;

namespace R.O.B.O.Core.Constants
{
    public static class Constantes
    {
        public static Dictionary<int, string> DicionarioRotacao = new Dictionary<int, string>() {
            { (int)Rotacao.Rotacao90Negativo, Rotacao.Rotacao90Negativo.ObterDisplayName() },
            { (int)Rotacao.Rotacao45Negativo, Rotacao.Rotacao45Negativo.ObterDisplayName() },
            { (int)Rotacao.EmRepouso, Rotacao.EmRepouso.ObterDisplayName() },
            { (int)Rotacao.Rotacao45, Rotacao.Rotacao45.ObterDisplayName() },
            { (int)Rotacao.Rotacao90, Rotacao.Rotacao90.ObterDisplayName() },
            { (int)Rotacao.Rotacao135, Rotacao.Rotacao135.ObterDisplayName() },
            { (int)Rotacao.Rotacao180, Rotacao.Rotacao180.ObterDisplayName() },
        };

        public static Dictionary<int, string> DicionarioInclinacao = new Dictionary<int, string>()
        {
            { (int)Inclinacao.ParaBaixo, Inclinacao.ParaBaixo.ObterDisplayName() },
            { (int)Inclinacao.EmRepouso, Inclinacao.EmRepouso.ObterDisplayName() },
            { (int)Inclinacao.ParaCima, Inclinacao.ParaCima.ObterDisplayName() }
        };

        public static Dictionary<int, string> DicionarioEstadoCotovelo = new Dictionary<int, string>()
        {
            { (int)EstadoCotovelo.EmRepouso, EstadoCotovelo.EmRepouso.ObterDisplayName() },
            { (int)EstadoCotovelo.LevementeContraido, EstadoCotovelo.LevementeContraido.ObterDisplayName() },
            { (int)EstadoCotovelo.Contraido, EstadoCotovelo.Contraido.ObterDisplayName() },
            { (int)EstadoCotovelo.FortementeContraido, EstadoCotovelo.FortementeContraido.ObterDisplayName() }
        };        
        
        public static Dictionary<string, Rotacao> DicionarioRotacaoCamposTela = new Dictionary<string, Rotacao>() {
            { Rotacao.Rotacao90Negativo.ObterDisplayName(), Rotacao.Rotacao90Negativo },
            { Rotacao.Rotacao45Negativo.ObterDisplayName(), Rotacao.Rotacao45Negativo },
            { Rotacao.EmRepouso.ObterDisplayName() , Rotacao.EmRepouso },
            { Rotacao.Rotacao45.ObterDisplayName() , Rotacao.Rotacao45 },
            { Rotacao.Rotacao90.ObterDisplayName() , Rotacao.Rotacao90 },
            { Rotacao.Rotacao135.ObterDisplayName() , Rotacao.Rotacao135 },
            { Rotacao.Rotacao180.ObterDisplayName() , Rotacao.Rotacao180 },
        };

        public static Dictionary<string, Inclinacao> DicionarioInclinacaoCamposTela = new Dictionary<string, Inclinacao>()
        {
            { Inclinacao.ParaBaixo.ObterDisplayName() , Inclinacao.ParaBaixo },
            { Inclinacao.EmRepouso.ObterDisplayName() , Inclinacao.EmRepouso },
            { Inclinacao.ParaCima.ObterDisplayName() , Inclinacao.ParaCima }
        };

        public static Dictionary<string, EstadoCotovelo> DicionarioEstadoCotoveloCamposTela = new Dictionary<string, EstadoCotovelo>()
        {
            { EstadoCotovelo.EmRepouso.ObterDisplayName() , EstadoCotovelo.EmRepouso },
            { EstadoCotovelo.LevementeContraido.ObterDisplayName() , EstadoCotovelo.LevementeContraido },
            { EstadoCotovelo.Contraido.ObterDisplayName() , EstadoCotovelo.Contraido },
            { EstadoCotovelo.FortementeContraido.ObterDisplayName() , EstadoCotovelo.FortementeContraido }
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
