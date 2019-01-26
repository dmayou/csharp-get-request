# C# Client
C# (pronounced C sharp) is a general-purpose, multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines. (Wikipedia)

My goals are to use C# as:
- to write Hello World to the console, and
- connect to a local server to consume a RESTful API

I will do this by making a console app so that the only output is to the console.

## About
Developers can build apps to run in the .NET framework or using ASP.NET with a browser. Applications coded in C# may function as client user interface in a browser, other parts of the client MVC stack, or as server-side code.

Learn more at: https://docs.microsoft.com/en-us/dotnet/csharp/
            https://docs.microsoft.com/en-us/dotnet/standard/
            https://docs.microsoft.com/en-us/aspnet/#pivot=aspnet

## Setup
To develop an app in C# using .NET, you must have an IDE (or at least an editor) and install the .NET framework.

### VS Code
Because I use VS Code to develop in a JavaScript-based stack, I will use it for this project. You can find instructions at this link:
https://code.visualstudio.com/docs/setup/setup-overview

### Install .NET
The .NET framework is installed as part of the .NET SDK, or software development kit found at this link:
```https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial```

Typing ```dotnet --version``` will return the version and show that the framework is installed.

If this does not work, it may be because the folder holding the dotnet executable is not in the path. The commands to remedy this vary by OS and location of the executable. The following command worked on my system.

```
ln -s /usr/local/share/dotnet/dotnet /usr/local/bin/
```

## Make a console app
From the Terminal prompt, execute this command:

```
dotnet new console -o myApp
```

## What you see
The foregoing command will create a folder structure for the project containing configuration files along with a Program.cs file with a basic Hello World application.

VS Code recognizes that this is a C# project that must be built in order to be run. (This differs from JavaScript code, which is interpreted by the browser.) VS Code prompts to install the assets needed to build and run the app.

The executable code is in the file Program.cs. The .cs extension identifies the file as containing C# code.

### Build and execute
From VS Code, choose Run Build Task from the Terminal menu.

You will see a message in the Terminal output that the build succeeded along with other information.

From the folder containing Program.cs, run the app from Terminal by typing:
```
dotnet run
```
This produces the expected output:
```
Hello World!
```

### Connect to REST API
I have recently authored full-stack projects that use node.js to provide a server-side connection to a database.

To write C# code to connect to that database, we must add a number of dependencies to Program.js and make the connection.

My Node.js server is running on the localhost on port 5000 and has a route \api\projects.

Typing 
```
dotnet run
```
will print the results from the chosen route. One can choose other routes or web-based api's by changing the url string on line 16 of Program.cs.

## Next steps
To round out the client-side use of C#, I will create a view in ASP.NET and adapt the code here to async code to provide the data to the view.
