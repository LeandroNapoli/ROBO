using R.O.B.O.Core.Enums;
using System;

namespace R.O.B.O.Core.Domains.Abstracts
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

            throw new ArgumentException($"Não é possível rotacionar o {Nome}, pois o estado selecionado não vem antes ou depois do estado atual");
        }

        public bool VerificarAlteracaoEstado(int estado)
        {
            if (estado == Estado - 1 || estado == Estado + 1)
                return true;

            throw new ArgumentException($"Não é possível movimentar o {Nome}, pois o estado selecionado não vem antes ou depois do estado atual");
        }

        public virtual void Rotacionar(int rotacao) => Rotacao = rotacao;
        public virtual void AlterarEstado (int estado) => Estado = estado;
    }
}