using R.O.B.O.Enums;

namespace R.O.B.O.Domains.Abstracts
{
    public abstract class Membro
    {
        public int Rotacao { get; set; } = 3;
        public int Estado { get; set; } = 1;
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