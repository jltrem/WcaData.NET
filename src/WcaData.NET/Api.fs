module WcaData.Api

open FSharp.Data



let baseUrl = "https://worldcubeassociation.org/api/v0/"

let getUser wcaId =
  Http.AsyncRequestString(baseUrl + "users/" + wcaId)
    

let getRecords = 
  Http.AsyncRequestString(baseUrl + "records/")
