using System.Net.Http;
using System.Threading.Tasks;

namespace Portal.Services
{
    public class TimeService : ITimeService
    {
        private readonly HttpClient _httpClient;

        public TimeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetTime() => await _httpClient.GetStringAsync(Program.API_ADDRESS);
    }
}
