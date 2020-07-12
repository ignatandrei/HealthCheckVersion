# HealthCheckVersion

## What it is

This NuGet package will report via [Health Check](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks)  the version of the starting  assembly . Also, it should report his own version - but not direct .

It will be easy to demo via [Xabaril](https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks)

## Why

To know from first hand if the application works and , if it does, to see fast his versin

## How to use

Add the NuGet package [HealthCheckVersion](nuget.org/packages/HealthCheckVersion).

In the Startup.cs 
``` csharp
services.AddHealthChecks()
    .AddCheck<HealthCheckVersion>("HealthCheckVersion");
```

Navigate to the HealthCheck JSON and see the reporting of the version of the starting assembly and of the own HealthCheckVersion assembly.

And that will be all!

(Maybe later I will think about a configuration for this - in order to customize the reporting)

## Tests

The application has also tests to see if it works. I will test just the obtaining the version of the starting assembly and HealthCheckVersion own assembly.

The first test will test the functions

GetStartingAssemblyInformation

GetHCVAssemblyInformation


