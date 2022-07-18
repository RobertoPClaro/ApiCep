using ApiCep.Models;
using ApiCep.Services;
using ApiCep.Validator;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace ApiCep.Controllers
{
    [ApiController]
    [Route("cep")]
    public class CepController
    {
        [HttpGet("{Cep}")]
        public CepResponse GetCep([FromRoute] CepRequest cepRequest)
        {            
            var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");//endereço da api viaCep com a inteface complementando
            return cepClient.GetAddressAsync(cepRequest.Cep).Result;
        }
    }
}
