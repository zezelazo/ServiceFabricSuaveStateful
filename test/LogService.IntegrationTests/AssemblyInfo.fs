﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("LogService.IntegrationTests")>]
[<assembly: AssemblyProductAttribute("LogService")>]
[<assembly: AssemblyDescriptionAttribute("Demo of F# Suave based Service Fabric stateless service")>]
[<assembly: AssemblyVersionAttribute("1.1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.1.0"
