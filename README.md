## Install the Kiota .NET Global Tool
```shell
dotnet new tool-manifest # if you are setting up this repo
dotnet tool install --local Microsoft.OpenApi.Kiota
```

## Generate the TypeScript SDK Using Kiota
```shell
dotnet kiota generate --language typescript --output ./generated --openapi http://localhost:5293/swagger/v1/swagger.json
```