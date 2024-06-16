using R.O.B.O.Core.Domains;
using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Helper;
using R.O.B.O.Core.ViewModels;
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
                    HttpContext.Current.Session["MembrosRobo"] = Enumerable.Empty<MembroViewModel>();
                }

                divErro.Visible = false;
                divSucesso.Visible = false;

                _roboService = new RoboService();
                await PreencherValoresMembros();
                PopularDropDowns();


            }
            catch (Exception ex)
            {
                divErro.Visible = true;
                divErro.InnerText = ex.Message;
            }
        }

        private async Task PreencherValoresMembros()
        {
            var membros = await _roboService.ObterMembros();
            var cotoveloDireito = membros.First(x => x.Nome == Membros.CotoveloDireito.ToString());
            var cotoveloEsquerdo = membros.First(x => x.Nome == Membros.CotoveloEsquerdo.ToString());
            var pulsoDireito = membros.First(x => x.Nome == Membros.PulsoDireito.ToString());
            var pulsoEsquerdo = membros.First(x => x.Nome == Membros.PulsoEsquerdo.ToString());
            var cabeca = membros.First(x => x.Nome == Membros.Cabeca.ToString());

            txtEstadoCotoveloDireito.Text = cotoveloDireito.Estado;
            txtEstadoCotoveloEsquerdo.Text = cotoveloEsquerdo.Estado;
            txtRotacaoPulsoDireito.Text = pulsoDireito.Rotacao;
            txtRotacaoPulsoEsquerdo.Text = pulsoEsquerdo.Rotacao;
            txtRotacaoCabeca.Text = cabeca.Rotacao;
            txtInclinacaoCabeca.Text = cabeca.Estado;
        }

        private void PopularDropDowns()
        {
            DropDownHelper.PopularDropDownPorEnum<EstadoCotovelo>(dpdCotoveloDireito);
            DropDownHelper.PopularDropDownPorEnum<EstadoCotovelo>(dpdCotoveloEsquerdo);
            DropDownHelper.PopularDropDownPorEnum<Inclinacao>(dpdInclinacaoCabeca);
            DropDownHelper.PopularDropDownPorEnum<Rotacao>(dpdRotacaoCabeca);
            DropDownHelper.PopularDropDownPorEnum<Rotacao>(dpdPulsoDireito);
            DropDownHelper.PopularDropDownPorEnum<Rotacao>(dpdPulsoEsquerdo);
        }

        protected void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            try
            {
                var bracoDireito = ObterBraco(dpdCotoveloDireito, dpdPulsoDireito, txtEstadoCotoveloDireito, txtRotacaoPulsoDireito, Membros.BracoDireito);
                var bracoEsquerdo = ObterBraco(dpdCotoveloEsquerdo, dpdPulsoEsquerdo, txtEstadoCotoveloEsquerdo, txtRotacaoPulsoEsquerdo, Membros.BracoEsquerdo);
                var cabeca = ObterCabeca();

                var membrosRobo = new MembrosRobo() { Cabeca = cabeca, Bracos = new HashSet<Braco>() { bracoDireito, bracoEsquerdo } };
                _roboService.AtualizarEstadosDosMembros(membrosRobo);

                divSucesso.Visible = true;
                divSucesso.InnerText = "Membros Atualizados";

            }
            catch (Exception ex) 
            {
                divErro.Visible = true;
                divErro.InnerText = ex.Message;
            }
        }

        private Cabeca ObterCabeca()
        {
            var cabeca = new Cabeca()
            {
                Nome = Membros.Cabeca
            };

            var estadoCabeca = dpdInclinacaoCabeca.SelectedValue == "" ? Convert.ToInt16(txtInclinacaoCabeca.Text) : Convert.ToInt16(dpdInclinacaoCabeca.SelectedValue);
            cabeca.VerificarAlteracaoEstado(estadoCabeca);
            cabeca.AlterarEstado(estadoCabeca);

            var rotacaoCabeca = dpdRotacaoCabeca.SelectedValue == "" ? Convert.ToInt16(txtRotacaoCabeca.Text) : Convert.ToInt16(dpdRotacaoCabeca.SelectedValue);
            cabeca.VerificarRotacaoCabeca(rotacaoCabeca);
            cabeca.Rotacionar(rotacaoCabeca);

            return cabeca;
        }

        private Braco ObterBraco(DropDownList dropDownCotovelo, DropDownList dropDownPulso, TextBox txtCotovelo, TextBox txtPulso, Membros membro)
        {
            var braco = new Braco()
            {
                Nome = membro,
                Cotovelo = new Cotovelo(),
                Pulso = new Pulso()
            };
            var estadoCotovelo = dropDownCotovelo.SelectedValue == "" ? Convert.ToInt16(txtCotovelo.Text) : Convert.ToInt16(dropDownCotovelo.SelectedValue);
            braco.Cotovelo.VerificarAlteracaoEstado(estadoCotovelo);
            braco.Cotovelo.AlterarEstado(estadoCotovelo);

            var rotacaoPulso = dropDownPulso.SelectedValue == "" ? Convert.ToInt16(txtPulso.Text) : Convert.ToInt16(dropDownPulso.SelectedValue);
            braco.Pulso.VerificarRotacaoPulso(braco.Cotovelo.Estado);
            braco.Pulso.VerificarRotacao(rotacaoPulso);
            braco.Pulso.Rotacionar(rotacaoPulso);

            return braco;
        }
    }
}