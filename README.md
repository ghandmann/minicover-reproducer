# Minimal Reproducer for Minicover not picking up ASP.net Core Integration Tests

See https://github.com/lucaslorentz/minicover/issues/103 for updates/fixes.

## Steps to reproduce

1) Clone this repository
2) Run `./test-and-cover.sh`
3) Check the Coverage-Report of `WebAPI/Controllers/ValuesController.cs`

## Expected

The `ValuesController.cs` should be covered by 100%.

## Actual

The `ValuesController.cs` is covered by 0%.

## Example Log

```
./test-and-cover.sh
  Restore completed in 15.63 ms for /tmp/Reproducer/Coverage/Coverage.csproj.
  Restore completed in 36.18 ms for /tmp/Reproducer/Coverage/Coverage.csproj.
  Restore completed in 18 ms for /tmp/Reproducer/WebAPITests/WebAPITests.csproj.
  Restore completed in 17.95 ms for /tmp/Reproducer/WebAPI/WebAPI.csproj.
Microsoft (R) Build Engine version 15.8.169+g1ccb72aefa for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 14.26 ms for /tmp/Reproducer/WebAPI/WebAPI.csproj.
  Restore completed in 39.32 ms for /tmp/Reproducer/Coverage/Coverage.csproj.
  Restore completed in 14.29 ms for /tmp/Reproducer/WebAPITests/WebAPITests.csproj.
  Restore completed in 11.37 ms for /tmp/Reproducer/Coverage/Coverage.csproj.
  Coverage -> /tmp/Reproducer/Coverage/bin/Debug/netcoreapp2.1/Coverage.dll
  WebAPI -> /tmp/Reproducer/WebAPI/bin/Debug/netcoreapp2.1/WebAPI.dll
  WebAPITests -> /tmp/Reproducer/WebAPITests/bin/Debug/netcoreapp2.1/WebAPITests.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.86
Assembly resolver search directories:
/tmp/Reproducer/WebAPITests/bin/Debug/netcoreapp2.1
/home/Username/.nuget/packages
/usr/share/dotnet/sdk/NuGetFallbackFolder

Instrumenting assembly "WebAPI"
Assembly resolver search directories:
/tmp/Reproducer/WebAPITests/bin/Debug/netcoreapp2.1
/home/Username/.nuget/packages
/usr/share/dotnet/sdk/NuGetFallbackFolder

Instrumenting assembly "WebAPITests"
Assembly resolver search directories:
/tmp/Reproducer/Coverage/bin/Debug/netcoreapp2.1

Changing working directory to '/tmp/Reproducer/'
Reset coverage for directory: '/tmp/Reproducer/' on pattern './coverage.hits'
Found 1 files to clear
/tmp/Reproducer/coverage.hits - removed
Reset operation completed without errors
Test run for /tmp/Reproducer/WebAPITests/bin/Debug/netcoreapp2.1/WebAPITests.dll(.NETCoreApp,Version=v2.1)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[0]
      User profile is available. Using '/home/Username/.aspnet/DataProtection-Keys' as key repository; keys will not be encrypted at rest.
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/2.0 GET http://localhost/api/values
warn: Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware[3]
      Failed to determine the https port for redirect.
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[1]
      Route matched with {action = "Get", controller = "Values"}. Executing action WebAPI.Controllers.ValuesController.Get (WebAPI)
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[1]
      Executing action method WebAPI.Controllers.ValuesController.Get (WebAPI) - Validation state: Valid
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[2]
      Executed action method WebAPI.Controllers.ValuesController.Get (WebAPI), returned result Microsoft.AspNetCore.Mvc.ObjectResult in 0.3511ms.
info: Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor[1]
      Executing ObjectResult, writing value of type 'System.String[]'.
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[2]
      Executed action WebAPI.Controllers.ValuesController.Get (WebAPI) in 33.1503ms
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 139.3157ms 200 application/json; charset=utf-8
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/2.0 GET http://localhost/api/values/5
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[1]
      Route matched with {action = "Get", controller = "Values"}. Executing action WebAPI.Controllers.ValuesController.Get (WebAPI)
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[1]
      Executing action method WebAPI.Controllers.ValuesController.Get (WebAPI) with arguments (5) - Validation state: Valid
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[2]
      Executed action method WebAPI.Controllers.ValuesController.Get (WebAPI), returned result Microsoft.AspNetCore.Mvc.ObjectResult in 0.1553ms.
info: Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor[1]
      Executing ObjectResult, writing value of type 'System.String'.
info: Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker[2]
      Executed action WebAPI.Controllers.ValuesController.Get (WebAPI) in 13.8514ms
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 24.0182ms 200 text/plain; charset=utf-8

Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.3570 Seconds
Changing working directory to '/tmp/Reproducer/'
+----------------------------------------+-------+---------------+------------+
| File                                   | Lines | Covered Lines | Percentage |
+----------------------------------------+-------+---------------+------------+
| WebAPI/Controllers/ValuesController.cs |    2  |        0      |  0.000000% |
| WebAPI/Program.cs                      |    3  |        2      | 66.666670% |
| WebAPI/Startup.cs                      |    9  |        7      | 77.777780% |
| WebAPITests/IntegrationTests.cs        |   12  |        6      | 50.000000% |
+----------------------------------------+-------+---------------+------------+
| All files                              |   26  |       15      | 57.692310% |
+----------------------------------------+-------+---------------+------------+
```