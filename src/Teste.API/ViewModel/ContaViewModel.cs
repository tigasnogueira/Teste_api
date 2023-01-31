using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Teste.API.ViewModel
{

    public class ContaViewModel
    {
        [JsonProperty("uf")]
        public Guid Id { get; set; }

        [JsonProperty("uf")]
        public string Logradouro { get; set; }

        [JsonProperty("uf")]
        public string Complemento { get; set; }

        [JsonProperty("uf")]
        public string Bairro { get; set; }

        [JsonProperty("uf")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("uf")]
        public string Ibge { get; set; }

        [JsonProperty("uf")]
        public string Gia { get; set; }

        [JsonProperty("uf")]
        public string DDD { get; set; }

        [JsonProperty("uf")]
        public string Siafi { get; set; }





    }
}
