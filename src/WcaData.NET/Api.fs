module WcaData.Api

open FSharp.Data



let baseUrl = "https://worldcubeassociation.org/api/v0/"

let getUser id =
  Http.AsyncRequestString(baseUrl + "users/" + id)

let getPerson wcaId =
  Http.AsyncRequestString(baseUrl + "persons/" + wcaId)    

let getRecords = 
  Http.AsyncRequestString(baseUrl + "records/")
