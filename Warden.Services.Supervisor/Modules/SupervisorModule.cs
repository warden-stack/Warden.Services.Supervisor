using Warden.Services.Supervisor.Domain;
using Warden.Services.Supervisor.Queries;
using Warden.Services.Supervisor.Services;

namespace Warden.Services.Supervisor.Modules
{
    public class SupervisorModule : ModuleBase
    {
        public SupervisorModule(ISupervisorService supervisorService) : base(requireAuthentication: false)
        {
            Get("supervisor", args => Fetch<GetSupervisorResult, SupervisorResult>
                (async x => await supervisorService.CheckServicesAsync()).HandleAsync());
        }
    }
}