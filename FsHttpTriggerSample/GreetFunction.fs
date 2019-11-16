namespace FsHttpTriggerSample

module GreetFunction = 

    open Microsoft.AspNetCore.Mvc
    open Microsoft.Azure.WebJobs
    open Microsoft.AspNetCore.Http
    open Newtonsoft.Json
    open System.IO
    open Microsoft.Extensions.Logging

    type User = {
        Name: string
    }

    [<FunctionName("Greet")>]
    let Run ([<HttpTrigger(Methods=[|"POST"|])>] req:HttpRequest) (log:ILogger) = 
        async {
            "Runnning Function"
            |> log.LogInformation

            let! body = 
                new StreamReader(req.Body) 
                |> (fun stream -> stream.ReadToEndAsync()) 
                |> Async.AwaitTask

            let user = JsonConvert.DeserializeObject<User>(body)

            return OkObjectResult(sprintf "Hello %s" user.Name)
        } |> Async.StartAsTask
        



