using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;

namespace HCVersion
{
    public class HealthCheckVersion : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var hcv = new HCV();
            var res = HealthCheckResult.Healthy(hcv.GetStartingAssemblyInformation(),
                new Dictionary<string, object>()
                {
                    {"Entry",hcv.GetStartingAssemblyInformation() },
                    {"HCV",hcv.GetHCVAssemblyInformation() }
                });

            return Task.FromResult( res);
        }
    }
}
