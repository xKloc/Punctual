﻿using Microsoft.Extensions.Configuration;

namespace Punctual.Internal
{
    internal class HostedServiceConfiguration<T> : IHostedServiceConfiguration<T>
    {
        public HostedServiceConfiguration(IScheduledActionConfigurationFactory HostedServiceConfigurationFactory)
        {
            Configuration = HostedServiceConfigurationFactory.GetConfiguration(typeof(T));
        }

        public IConfiguration Configuration { get; }
    }
}
