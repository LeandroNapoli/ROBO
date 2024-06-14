using R.O.B.O.Domains;
using R.O.B.O.Services.IServices;
using R.O.B.O.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace R.O.B.O.Services
{
    public class RoboService : IRoboService
    {
        public Task AtualizarEstadosDosMembros(IEnumerable<Membro> membroViews)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MembroViewModel>> ObterEstadosDosMembros()
        {
            throw new NotImplementedException();
        }
    }
}