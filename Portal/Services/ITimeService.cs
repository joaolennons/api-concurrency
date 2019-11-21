using System.Threading.Tasks;

namespace Portal.Services
{
    public interface ITimeService
    {
        Task<string> GetTime();
    }
}