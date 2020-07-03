module WcaData.NET

open WcaData.ApiTypes
open Newtonsoft.Json

let private deserialize<'T> (get:Async<string>) =
    get
    |> Async.RunSynchronously
    |> JsonConvert.DeserializeObject<'T> 

// id can be either integer id (7831) or WCA id (2009ZEMD01)
let getUser id = 
    Api.getUser id
    |> deserialize<GetUser> 
    |> fun x -> x.user

let getPerson wcaId = 
    Api.getPerson wcaId
    |> deserialize<GetPerson>
   
let getRecords = 
    Api.getRecords
    |> deserialize<GetRecords> 

