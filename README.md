# Building Microservices

### Setup Commands

```
dotnet new sln -o MicroSvc
cd MicroSvc

dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet tool install Microsoft.dotnet-httprepl

dotnet new classlib -o Lib
dotnet new xunit -o Test
dotnet new webapi --no-https -o Web1
dotnet new webapi --no-https -o Web2

dotnet sln add Lib/Lib.csproj
dotnet sln add Test/Test.csproj
dotnet sln add Web1/Web1.csproj
dotnet sln add Web2/Web2.csproj

cd Test
dotnet add reference ../Web1/Web1.csproj
dotnet add reference ../Web2/Web2.csproj
dotnet add package Moq
dotnet add package FluentAssertions

cd Web1
dotnet add reference ../Lib/Lib.csproj
dotnet add package Microsoft.Extensions.Logging.Console
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore

cd Web2
dotnet add reference ../Lib/Lib.csproj
dotnet add package Microsoft.Extensions.Logging.Console
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore

dotnet build
touch README.md
git init
touch .gitignore
```
