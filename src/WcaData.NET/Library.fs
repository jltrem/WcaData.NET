module WcaData.NET

open WcaData.ApiTypes
open Newtonsoft.Json


let getUser id = 
    Api.getUser id
    |> Async.RunSynchronously
    |> JsonConvert.DeserializeObject<GetUser> 
    |> fun x -> x.user


let getRecords = 
    Api.getRecords
    |> Async.RunSynchronously
    |> JsonConvert.DeserializeObject<GetRecords> 

