
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
            | User _ -> "get user by WCA id"
            | Records _ -> "get world records"

 


[<EntryPoint>]
let main argv =

    let errorHandler = ProcessExiter(colorizer = function ErrorCode.HelpText -> None | _ -> Some ConsoleColor.Red)
    let parser = ArgumentParser.Create<WcaArguments>(programName = "wca-cli", errorHandler = errorHandler)


    let run (getStr:Async<string>) =
        Async.RunSynchronously getStr
        |> printfn "%s" 


    (*

    get USA record for 3x3

    getRecords
    |> fun x -> x.national_records.TryFind "USA"
    |> Option.bind (fun x -> x.TryFind("333"))
    |> Option.map (fun x -> ((float x.single) / 100.0, (float x.average) / 100.0))
    |> Option.map (fun x -> printfn "USA record for 3x3 single = %2.3f seconds; average = %2.3f seconds" (fst x) (snd x))
    |> ignore

    *)

    match parser.ParseCommandLine argv with
    | id when id.Contains(User) -> id.GetResult(User) |> getUser |> printfn "%A"
    | x when x.Contains(Records) -> getRecords |> printfn "%A"
    | _ -> printfn "%s" (parser.PrintUsage())

    //|> Option.map GET.user

    0 