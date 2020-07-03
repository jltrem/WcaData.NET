
open System
open WcaData.NET


open Argu

[<CliPrefix(CliPrefix.DoubleDash)>]
[<NoAppSettings>]
type WcaArguments =
    | User of user:string
    | Records

    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | User _ -> "get use by WCA id"
            | Records _ -> "get world records"

 


[<EntryPoint>]
let main argv =

    let errorHandler = ProcessExiter(colorizer = function ErrorCode.HelpText -> None | _ -> Some ConsoleColor.Red)
    let parser = ArgumentParser.Create<WcaArguments>(programName = "wca-cli", errorHandler = errorHandler)


    let run (getStr:Async<string>) =
        Async.RunSynchronously getStr
        |> printfn "%s" 

    match parser.ParseCommandLine argv with
    | id when id.Contains(User) -> id.GetResult(User) |> getUser |> printfn "%A"
    | x when x.Contains(Records) -> printfn "%s" "get records"
    | _ -> printfn "%s" (parser.PrintUsage())

    //|> Option.map GET.user

    0 