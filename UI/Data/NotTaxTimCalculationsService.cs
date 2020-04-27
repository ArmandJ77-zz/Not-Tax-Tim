using System.Net.Http;
using System.Threading.Tasks;
using UI.Infrastructure;

namespace UI.Data
{
    public class NotTaxTimCalculationsService
    {
        private HttpClient _client;
        public NotTaxTimCalculationsService()
        {
            _client = new HttpClient();
        }
        public async Task<CalculationsCreateResponse> Calculate(CalculationsCreateCommand cmd)
        {
            var response =
                await _client.PostAsJsonAsync("https://localhost:44344/api/calculations", cmd);

            var result = response.Content.Deserialize<CalculationsCreateResponse>().Result;

            return result;
        }
    }
}
