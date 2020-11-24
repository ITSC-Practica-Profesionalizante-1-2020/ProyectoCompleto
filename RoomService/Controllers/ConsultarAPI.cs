using Newtonsoft.Json;
using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RoomService.Controllers
{
    public class ConsultarAPI
    {

        public async Task<Cliente> GetClienteAsync(string email)
        {


        HttpClient httpClient = new HttpClient();

            string server = "https://localhost:44344/";
            string url = "api/Clientes/Validar/";
            var resp = await httpClient.GetAsync(server + url + email);
        var response = resp.Content.ReadAsStringAsync();
        Cliente cliente = JsonConvert.DeserializeObject<Cliente>(response.Result);
            return cliente;

        }


    }
}
