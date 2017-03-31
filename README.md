# ASPNETCoreAngular

#This is for project.json or VS 2015 version

Please check https://github.com/Longfld/ASPNETCoreAngular for VS2017 or csproj version

Angular 4 (& material) in ASP.NET Core with TypeScript by systemjs

If you are looking for angular 4 (+ material) by systemjs as frontend, asp.net core web api as backend, there is the solution.

How to use it?


After download, go to the folder that contain package.json. Firstly, check your dotnet version by run:

>dotnet --version

As in global.json : "version": "1.0.0-preview2-003121"

Then you can:

>npm install

>dotnet restore

Now, we need to compile typescript, just need run this (and always run this after angular/typescript modify):

> npm start  

Finally start dotnet and browser http://localhost:5000
>dotnet run



If you are using Visual Studio 2015, just open the project and run it, if you have problem, make sure you have latest version of VS2015 typescript installed by go here ( http://www.microsoft.com/en-us/download/details.aspx?id=48593 ), download and install typescript before try again.
