using System.Collections.Generic;

namespace Warden.Services.Supervisor.Settings
{
    public class SupervisorSettings
    {
        public string Url { get; set; }
        public IList<Service> Services { get; set; }

        public class Service 
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public IList<ServiceInstance> Instances { get; set; }
        }

        public class ServiceInstance 
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public string BrowsableUrl { get; set; }
        }
    }
}