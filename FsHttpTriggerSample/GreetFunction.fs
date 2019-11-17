namespace FsHttpTriggerSample

module GreetFunction = 

    open Microsoft.AspNetCore.Mvc
    open Microsoft.Azure.WebJobs
    open Microsoft.AspNetCore.Http
    open Newtonsoft.Json
    open System.IO
    open Microsoft.Extensions.Logging

    [<CLIMutable>]
    type User = {
        Name: string
    }

    [<FunctionName("Greet")>]
    let Run ([<HttpTrigger(Methods=[|"POST"|])>] req:User) (log:ILogger) = 
        async {
            "Runnning Function"
            |> log.LogInformation

            return OkObjectResult(sprintf "Hello %s" req.Name)
        } |> Async.StartAsTask