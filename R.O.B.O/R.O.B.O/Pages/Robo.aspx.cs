using R.O.B.O.Services;
using R.O.B.O.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace R.O.B.O.Pages
{
    public partial class Robo : System.Web.UI.Page
    {
        private IRoboService _roboService;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.RegisterAsyncTask(new PageAsyncTask(() => CarregarPagina(sender, e)));
        }

        protected async Task CarregarPagina(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    _roboService = new RoboService();
                    var membros = await _roboService.ObterEstadosDosMembros();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}