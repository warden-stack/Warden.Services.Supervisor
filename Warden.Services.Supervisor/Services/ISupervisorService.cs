using System.Threading.Tasks;
using Warden.Services.Supervisor.Domain;

namespace Warden.Services.Supervisor.Services
{
    public interface ISupervisorService
    {
         Task<SupervisorResult> CheckServicesAsync();
    }
}