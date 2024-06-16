using Newtonsoft.Json;
using R.O.B.O.Core.Constants;
using R.O.B.O.Core.Domains;
using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Extensions;
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
        protected void Page_Init(object sender, EventArgs e)
        {
            _roboService = new RoboService();
        }
        protected async void Page_Load(object sender, EventArgs e)
        {
            await CarregarPagina(sender, e);
        }

        protected async Task CarregarPagina(object sender, EventArgs e)
        {
            try
            {
                LimparAlertas();

                if (!IsPostBack)
                {
                    HttpContext.Current.Session["MembrosRobo"] = JsonConvert.SerializeObject(Enumerable.Empty<MembroViewModel>());
                    PopularDropDowns();
                }
                
                await PreencherValoresMembros();

            }
            catch (Exception ex)
            {
                MostrarAlertaErro(ex.Message);
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
            DropDownHelper.PopularDropDownPorEnum<RotacaoCabeca>(dpdRotacaoCabeca);
            DropDownHelper.PopularDropDownPorEnum<Rotacao>(dpdPulsoDireito);
            DropDownHelper.PopularDropDownPorEnum<Rotacao>(dpdPulsoEsquerdo);
        }

        protected async void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            try
            {
                var bracoDireito = ObterBraco(dpdCotoveloDireito, dpdPulsoDireito, txtEstadoCotoveloDireito, txtRotacaoPulsoDireito, Membros.BracoDireito);
                var bracoEsquerdo = ObterBraco(dpdCotoveloEsquerdo, dpdPulsoEsquerdo, txtEstadoCotoveloEsquerdo, txtRotacaoPulsoEsquerdo, Membros.BracoEsquerdo);
                var cabeca = ObterCabeca();

                var membrosRobo = new MembrosRobo() { Cabeca = cabeca, Bracos = new HashSet<Braco>() { bracoDireito, bracoEsquerdo } };
                await _roboService.AtualizarEstadosDosMembros(membrosRobo);

                MostrarAlertaSucesso("Membros Robo Atualizados");
            }
            catch (Exception ex)
            {
                MostrarAlertaErro(ex.Message);
            }
            finally
            {
                PopularDropDowns();
                await PreencherValoresMembros();
            }
        }

        private Cabeca ObterCabeca()
        {
            var cabeca = new Cabeca()
            {
                Nome = Membros.Cabeca,
                Rotacao = (int)Constantes.DicionarioRotacaoCamposTela[txtRotacaoCabeca.Text],
                Estado = (int)Constantes.DicionarioInclinacaoCamposTela[txtInclinacaoCabeca.Text]
            };

            var estadoCabeca = dpdInclinacaoCabeca.SelectedValue == "" ? (int)Constantes.DicionarioInclinacaoCamposTela[txtInclinacaoCabeca.Text] : Convert.ToInt16(dpdInclinacaoCabeca.SelectedValue);

            if (!Equals(estadoCabeca, (int)Constantes.DicionarioInclinacaoCamposTela[txtInclinacaoCabeca.Text]))
                cabeca.VerificarAlteracaoEstado(estadoCabeca);

            cabeca.AlterarEstado(estadoCabeca);

            var rotacaoCabeca = dpdRotacaoCabeca.SelectedValue == "" ? (int)Constantes.DicionarioRotacaoCamposTela[txtRotacaoCabeca.Text] : Convert.ToInt16(dpdRotacaoCabeca.SelectedValue);

            if (!Equals(rotacaoCabeca, (int)Constantes.DicionarioRotacaoCamposTela[txtRotacaoCabeca.Text]))
                cabeca.VerificarRotacaoCabeca(rotacaoCabeca);

            cabeca.Rotacionar(rotacaoCabeca);

            return cabeca;
        }

        private Braco ObterBraco(DropDownList dropDownCotovelo, DropDownList dropDownPulso, TextBox txtCotovelo, TextBox txtPulso, Membros membro)
        {

            var braco = new Braco()
            {
                Nome = membro,
                Cotovelo = new Cotovelo() { Nome = Constantes.DicionarioCotoveloCriacaoBraco[membro], Estado = (int)Constantes.DicionarioEstadoCotoveloCamposTela[txtCotovelo.Text] },
                Pulso = new Pulso() { Nome = Constantes.DicionarioPulsoCriacaoBraco[membro], Rotacao = (int)Constantes.DicionarioRotacaoCamposTela[txtPulso.Text] }
            };

            var estadoCotovelo = dropDownCotovelo.SelectedValue == "" ? braco.Cotovelo.Estado : Convert.ToInt16(dropDownCotovelo.SelectedValue);

            if (!Equals(estadoCotovelo, (int)Constantes.DicionarioEstadoCotoveloCamposTela[txtCotovelo.Text]))
                braco.Cotovelo.VerificarAlteracaoEstado(estadoCotovelo);

            braco.Cotovelo.AlterarEstado(estadoCotovelo);

            var rotacaoPulso = dropDownPulso.SelectedValue == "" ? braco.Pulso.Rotacao : Convert.ToInt16(dropDownPulso.SelectedValue);
            if (!Equals(rotacaoPulso, (int)Constantes.DicionarioRotacaoCamposTela[txtPulso.Text]))
            {
                braco.Pulso.VerificarRotacaoPulso(braco.Cotovelo.Estado, Constantes.DicionarioCotoveloCriacaoBraco[membro]);
                braco.Pulso.VerificarRotacao(rotacaoPulso);
            }

            braco.Pulso.Rotacionar(rotacaoPulso);

            return braco;
        }

        private void MostrarAlertaErro(string mensagem)
        {
            divErro.Visible = true;
            divErro.InnerText = mensagem;
        }

        private void MostrarAlertaSucesso(string mensagem)
        {
            divSucesso.Visible = true;
            divSucesso.InnerText = mensagem;
        }
        private void LimparAlertas()
        {
            divErro.Visible = false;
            divSucesso.Visible = false;
        }
    }
}