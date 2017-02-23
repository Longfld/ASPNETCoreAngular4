# ASPNETCoreAngular2


Angular (& material)2 in ASP.NET Core with TypeScript by systemjs

If you are looking for angular (+ material) 2 by systemjs as frontend, asp.net core web api as backend, there is the solution.

How to use it?


After download, go to the folder that contain package.json

>npm install

>dotnet restore

Now, we need to compile typescript, if you are sure your global installed typescript is 2.0.10(that is version in our package.json) or above, just need run:

>tsc

If you are not sure or above does not work, try this:
> npm start  

Finally start dotnet and browser http://localhost:5000
>dotnet run



If you are using Visual Studio 2015, just open the project and run it, if you have problem, make sure you have latest version of VS2015 typescript installed by go here ( http://www.microsoft.com/en-us/download/details.aspx?id=48593 ), download and install typescript before try again.
