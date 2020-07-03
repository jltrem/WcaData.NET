module WcaData.NET

open WcaData.ApiTypes
open Newtonsoft.Json


let getUser id = 
    WcaData.Api.getUser id
    |> Async.RunSynchronously
    |> JsonConvert.DeserializeObject<GetUser> 
    |> fun x -> x.user


