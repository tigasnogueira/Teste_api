using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Teste.Domain.Interfaces;
using Teste.Domain.Models;

namespace Teste.Service.Services 
{
    public class CepService : ICepService
    {
        public async Task GetCep()
        {
            RestClient client = new RestClient("http://viacep.com.br/ws/01001000/json/");

            RestRequest request = new RestRequest("http://viacep.com.br/ws/01001000/json/", Method.Get);
            var response = await client.ExecuteGetAsync(request);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var cep = JsonSerializer.Deserialize<ContaModel>(response.Content, options);


        }


    }
}
