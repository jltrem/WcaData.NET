module WcaData.Api

open FSharp.Data



let baseUrl = "https://worldcubeassociation.org/api/v0/"

let getUser wcaId =

    async { 
        let! json = Http.AsyncRequestString(baseUrl + "users/" + wcaId)
        return json 
    }
