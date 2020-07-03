
open System
open WcaData.NET

[<EntryPoint>]
let main argv =
    GET.user "2008KORI02"
    |> Async.RunSynchronously
    |> printfn "%s"

    0 