﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Actor")>]
[<assembly: AssemblyProductAttribute("FSharp.Actor")>]
[<assembly: AssemblyDescriptionAttribute("An actor library for F#.")>]
[<assembly: AssemblyVersionAttribute("0.0.8")>]
[<assembly: AssemblyFileVersionAttribute("0.0.8")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.8"
