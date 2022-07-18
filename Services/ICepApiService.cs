using ApiCep.Models;
using Refit;
using System.Threading.Tasks;

namespace ApiCep.Services
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")] //rota get, cep passado por parametro
        Task<CepResponse> GetAddressAsync(string cep);// executa a tarefa de obter um endereço assíncrono
    }
}
