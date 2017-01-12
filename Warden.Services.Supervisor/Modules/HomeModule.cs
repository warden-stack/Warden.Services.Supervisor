using Warden.Services.Supervisor.Settings;

namespace Warden.Services.Supervisor.Modules
{
    public class HomeModule : ModuleBase
    {
        public HomeModule(SupervisorSettings settings) : base(requireAuthentication: false)
        {
            Get("", args => "Welcome to the Warden.Services.Supervisor API!");

            Get("dashboard", args => View["wwwroot/views/dashboard/index", settings]);
        }
    }
}