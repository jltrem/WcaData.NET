namespace WcaData.NET

open FSharp.Data

module GET =

    let baseUrl = "https://worldcubeassociation.org/api/v0/"

    let user id =

        async { 
            let! json = Http.AsyncRequestString(baseUrl + "users/" + id)
            return json 
        }
