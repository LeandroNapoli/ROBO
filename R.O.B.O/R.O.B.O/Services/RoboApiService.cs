using R.O.B.O.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using R.O.B.O.Core.Domains;
using R.O.B.O.Services.IServices;
using Newtonsoft.Json;

namespace R.O.B.O.Services
{
    public class RoboApiService : IRoboApiService
    {
        private string _urlPadraoApi = ConfigurationManager.AppSettings["R.O.B.O.Api"].ToString();
        private const string _urlPadraoRobo = "robo";
        private HttpClient _httpClient;

        public RoboApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<MembroViewModel>> ObterMembros()
        {
            try
            {
                var resultado = await _httpClient.GetAsync($"{_urlPadraoApi}{_urlPadraoRobo}/obter-membros");

                if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new Exception("Erro ao obter Membros do R.O.B.O");

                var data = await resultado.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<MembroViewModel>>(data);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtualizarMembros(MembrosRobo membros)
        {
            try
            {
                var stringContent = ObterContent(membros);

                var resultado = await _httpClient.PutAsync($"{_urlPadraoApi}/{_urlPadraoRobo}/atualizar-membros", stringContent);

                if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new Exception("Erro ao obter Membros do R.O.B.O");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private StringContent ObterContent(MembrosRobo membros)
        {
            var content = JsonConvert.SerializeObject(membros);
            return new StringContent(content);
        }
    }
}