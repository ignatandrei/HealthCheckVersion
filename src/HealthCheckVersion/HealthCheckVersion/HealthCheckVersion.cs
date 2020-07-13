using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;

namespace HCVersion
{
    /// <summary>
    /// Health Check that reports version
    /// </summary>
    /// <seealso cref="Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck" />
    public class HealthCheckVersion : IHealthCheck
    {
        /// <summary>
        /// Runs the health check, returning the status of the component being checked.
        /// </summary>
        /// <param name="context">A context object associated with the current execution.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> that can be used to cancel the health check.</param>
        /// <returns>
        /// A <see cref="T:System.Threading.Tasks.Task`1" /> that completes when the health check has finished, yielding the status of the component being checked.
        /// </returns>
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
