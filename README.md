# Azure Functions HTTP Trigger FSharp Sample

This sample shows how to build an Azure Function that processes HTTP requests using F#. See the blog post [Create an HTTP Trigger Azure Function using FSharp](http://luisquintanilla.me/2019/11/16/http-trigger-azure-functions-fsharp/) for a detailed walk-through on how to build this sample.

## Prerequisites

This solution was built using a Windows PC but should work on Mac and Linux.

- [.NET SDK (2.x or 3.x)](https://dotnet.microsoft.com/download/dotnet-core)
- [Node.js](https://nodejs.org/en/download/)
- [Azure Functions Core Tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#windows-npm)

## Run the Function Locally

Build the project by using the `build` command inside the *FsHttpTriggerSample* project directory.

```bash
dotnet build
```

Then, navigate to the output directory

```bash
cd bin\Debug\netstandard2.0
```

Use the Azure Functions Core Tools to start the Azure Functions host locally.

```bash
func host start
```

Once the host is initialized, the function is available at the following endpoint `http://localhost:7071/api/Greet`.

## Test the function

Using a REST client like Postman or Insomnia, make a POST request to `http://localhost:7071/api/Greet` with the following body. Feel free to replace the name with your own.

```json
{
    "Name": "Luis"
}
```

If successful, the response should look similar to the following output.

```text
Hello Luis
```
