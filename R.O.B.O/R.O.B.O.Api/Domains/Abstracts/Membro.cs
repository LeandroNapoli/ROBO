using R.O.B.O.Api.Enums;

namespace R.O.B.O.Api.Domains.Abstracts
{
    public abstract class Membro
    {
        public int Rotacao { get; set; }
        public int Estado { get; set; }
        public Membros Nome { get; set; }
        public bool VerificarRotacao(int rotacao)
        {
            if (rotacao == Rotacao - 1 || rotacao == Rotacao + 1)
                return true;

            return false;
        }

        public virtual void Rotacionar(int rotacao) => Rotacao = rotacao;
    }
}