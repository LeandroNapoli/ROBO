﻿using R.O.B.O.Core.Domains;

namespace R.O.B.O.Api.Repositories.IRepositories
{
    public interface IRoboRepository
    {
        MembrosRobo AtualizarMembros(MembrosRobo membro);
        MembrosRobo ObterMembros();
    }
}
