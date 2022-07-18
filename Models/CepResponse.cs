using Newtonsoft.Json;

namespace ApiCep.Models

{
    public class CepResponse
    {
        [JsonProperty("cep")]//para dizer que o cep é o Cep
        public string Cep { get; set; }

        [JsonProperty("logradouro")]//para dizer que o logradouro é o Logradouro
        public string Logradouro { get; set; }

        [JsonProperty("complemento")] //para dizer que o complemento é o Complemento
        public string Complemento { get; set; }

        [JsonProperty("bairro")]//para dizer que o bairro é o Bairro
        public string Bairro { get; set; }

        [JsonProperty("localidade")]//para dizer que o localidade é o Localidade
        public string Localidade { get; set; }

        [JsonProperty("uf")]//para dizer que o uf é o Uf
        public string Uf { get; set; }

        [JsonProperty("ibge")]//para dizer que o ibge é o Ibge
        public string Ibge { get; set; }

        [JsonProperty("gia")]//para dizer que o gia é o Gia
        public string Gia { get; set; }

        [JsonProperty("ddd")]//para dizer que o ddd é o Ddd
        public string Ddd { get; set; }

        [JsonProperty("siafi")]//para dizer que o siafi é o Siafi
        public string Siafi { get; set; }
    }
}
